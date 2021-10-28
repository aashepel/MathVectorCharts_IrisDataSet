using MathVectorCharts.Infrastucture.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace MathVectorCharts.Infrastucture.Persistence.Parsers
{
    public static class DefaultParsers
    {
        public static CsvParser<T> CsvParserDefault<T>(CsvMapping<T> csvMapping, string filePath)
            where T : class, new()
        {
            return new CsvParser<T>
                (new CsvParserOptions(true, ','), csvMapping, filePath);
        }

        public static JsonParser<T> JsonParserDefault<T>(string filePath)
            where T : class, new()
        {
            return new JsonParser<T>(filePath);
        }
    }
}
