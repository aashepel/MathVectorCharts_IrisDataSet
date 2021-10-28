using MathVectorCharts.Domain.Entities;
using TinyCsvParser.Mapping;

namespace MathVectorCharts.Infrastucture.Persistence
{
    public class CsvIrisMapping : CsvMapping<Iris>
    {
        public CsvIrisMapping() 
            : base()
        {
            MapProperty(0, x => x.SepalLength);
            MapProperty(1, x => x.SepalWidth);
            MapProperty(2, x => x.PetalLength);
            MapProperty(3, x => x.PetalWidth);
            MapProperty(4, x => x.TypeIris);
        }
    }
}
