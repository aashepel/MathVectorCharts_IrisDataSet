using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts
{
    public class IrisesDataSet
    {
        private List<ConcreteTypeIrisDataSet> _irises;
        public IrisesDataSet()
        {
            _irises = new List<ConcreteTypeIrisDataSet>();
        }
        public List<ConcreteTypeIrisDataSet> Irises
        {
            get { return _irises; }
        }
        public void Add(Iris iris)
        {
            var dataSetConcreteIris = _irises.FirstOrDefault(p => p.Type == iris.TypeIris);
            if (dataSetConcreteIris == null)
            {
                _irises.Add(new ConcreteTypeIrisDataSet(iris.TypeIris));
                dataSetConcreteIris = _irises.FirstOrDefault(p => p.Type == iris.TypeIris);
                dataSetConcreteIris.Add(iris);
            }
            else
            {
                dataSetConcreteIris.Add(iris);
            }
        }
        public override string ToString()
        {
            string result = "";
            foreach (var typeIris in _irises)
            {
                result += typeIris;
            }
            return result;
        }
    }
}
