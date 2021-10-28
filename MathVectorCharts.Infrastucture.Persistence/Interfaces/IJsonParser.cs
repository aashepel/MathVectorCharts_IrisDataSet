using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Infrastucture.Persistence.Interfaces
{
    public interface IJsonParser<T> : IParser<T> where T : class, new()
    {

    }
}
