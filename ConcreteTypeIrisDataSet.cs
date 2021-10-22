using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts
{
    public class ConcreteTypeIrisDataSet
    {
        //sepal_length,sepal_width,petal_length,petal_width
        private List<Iris> _irises;
        public ConcreteTypeIrisDataSet(string type)
        {
            _irises = new List<Iris>();
            Type = type;
        }
        public string Type { get; set; }
        public List<Iris> Irises
        {
            get { return _irises; }
        }
        public void Add(Iris iris)
        {
            _irises.Add(iris);
        }
        public double ArithmeticMeanOfColumn(int indexField)
        {
            double sum = 0;
            int counter = 0;
            foreach(Iris iris in _irises)
            {
                sum += iris.VectorParams[indexField];
                counter++;
            }
            return sum / counter;
        }
        public double ArithmeticMeanSepalLength()
        {
            return ArithmeticMeanOfColumn(0);
        }
        public double ArithmeticMeanSepalWidth()
        {
            return ArithmeticMeanOfColumn(1);
        }
        public double ArithmeticMeanPetalLength()
        {
            return ArithmeticMeanOfColumn(2);
        }
        public double ArithmeticMeanPetalWidth()
        {
            return ArithmeticMeanOfColumn(3);
        }
        public override string ToString()
        {
            string result = "";
            result += "-------------------------------------------------------------\n";
            result += $"TYPE: {Type.ToUpper()}\n";
            result += $"ArithmeticMeanSepalLength: {ArithmeticMeanSepalLength()}\n";
            result += $"ArithmeticMeanSepalWidth: {ArithmeticMeanSepalWidth()}\n";
            result += $"ArithmeticMeanPetalLength: {ArithmeticMeanPetalLength()}\n";
            result += $"ArithmeticMeanPetalWidth: {ArithmeticMeanPetalWidth()}\n";
            foreach (var iris in _irises)
            {
                result += iris;
                result += '\n';
            }
            result += "-------------------------------------------------------------\n";
            return result;
        }
    }
}
