using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Infrastucture.Persistence.Interfaces
{
    public interface IParser<T> where T : class
    {
        List<T> GetRecords();
        string FilePath { get; set; }
    }
}
