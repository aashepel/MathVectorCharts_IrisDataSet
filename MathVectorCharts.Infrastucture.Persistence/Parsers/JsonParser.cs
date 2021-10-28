using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Infrastucture.Persistence.Parsers
{
    public class JsonParser<T> : BaseParser<T>, Interfaces.IJsonParser<T>
        where T : class, new()
    {
        public JsonParser(string filePath) : base(filePath)
        {

        }

        public override List<T> GetRecords()
        {
            throw new NotImplementedException();
        }
    }
}
