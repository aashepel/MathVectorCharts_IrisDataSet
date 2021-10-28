using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace MathVectorCharts.Infrastucture.Persistence.Interfaces
{
    public interface ICsvParser<T> : IParser<T> where T : class, new()
    {
        CsvParserOptions CsvParserOptions { get; set; }
        CsvMapping<T> CsvMapping { get; set; }
        List<string> Headers { get; }
    }
}
