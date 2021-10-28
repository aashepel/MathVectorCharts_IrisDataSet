using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace MathVectorCharts.Infrastucture.Persistence
{
    public interface IParser<T> where T : class
    {
        List<T> GetRecords();
        string FilePath { get; set; }
    }
    public interface ICsvParser<T> : IParser<T> where T: class, new()
    {
        CsvParserOptions CsvParserOptions { get; set; }
        CsvMapping<T> CsvMapping { get; set; }
    }
    public abstract class Parser<T> : IParser<T> where T : class
    {
        private string _filePath;
        public Parser(string filePath)
        {
            _filePath = filePath;
        }
        public abstract List<T> GetRecords();
        public virtual string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
    }
    public class CsvParser<T> : Parser<T>, ICsvParser<T> where T : class, new()
    {
        private TinyCsvParser.CsvParser<T> _parser;
        private CsvParserOptions _csvParserOptions = new CsvParserOptions(true, ',');
        private CsvMapping<T> _csvMapper;

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

        public override List<T> GetRecords()
        {
            var records = _parser
                .ReadFromFile(FilePath, Encoding.UTF8)
                .ToList();
            var resultListObject = new List<T>();
            foreach(var record in records)
            {
                resultListObject.Add(record.Result);
            }
            return resultListObject;

        }
    }
}
