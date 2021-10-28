using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;
using MathVectorCharts.Domain.Exceptions;
using System.IO;

namespace MathVectorCharts.Infrastucture.Persistence.Parsers
{
    public class CsvParser<T> : BaseParser<T>, Interfaces.ICsvParser<T> where T : class, new()
    {
        private TinyCsvParser.CsvParser<T> _parser;
        private CsvParserOptions _csvParserOptions = new CsvParserOptions(true, ',');
        private CsvMapping<T> _csvMapper;
        private List<string> _headers;

        public CsvParser(CsvParserOptions csvParserOptions, CsvMapping<T> csvMapper, string filePath) : base(filePath)
        {
            _csvParserOptions = csvParserOptions;
            _csvMapper = csvMapper;
            _parser = new TinyCsvParser.CsvParser<T>(_csvParserOptions, csvMapper);
        }

        public CsvParserOptions CsvParserOptions
        {
            get => _csvParserOptions;
            set => _csvParserOptions = value;
        }

        public CsvMapping<T> CsvMapping
        {
            get => _csvMapper;
            set => _csvMapper = value;
        }

        public List<string> Headers
        {
            get => _headers;
        }

        public override List<T> GetRecords()
        {
            var records = 
                _parser
                .ReadFromFile(FilePath, Encoding.UTF8)
                .ToList();
            var resultListObject = new List<T>();
            foreach (var record in records)
            {
                if (record.IsValid)
                {
                    resultListObject.Add(record.Result);
                }
                else
                {
                    throw new InvalidFileContentException();
                }
            }
            _headers = 
                File.ReadLines(FilePath)
                .ToList()
                .FirstOrDefault()
                ?.Split(',')
                .ToList();
            return resultListObject;
        }
    }
}
