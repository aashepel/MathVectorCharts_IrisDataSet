using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts
{
    public class Iris
    {
        //sepal_length,sepal_width,petal_length,petal_width,
        private MathVector _vectorParams;
        private string _typeIris;
        private static List<string> _nameOfParams = new List<string> { "sepal_length", "sepal_width", "petal_length", "petal_width" };
        public Iris(MathVector vectorParams, string typeIris)
        {
            _vectorParams = vectorParams;
            _typeIris = typeIris;
        }
        public static List<string> NameOfParams
        { 
            get { return _nameOfParams; }
        }
        public MathVector VectorParams
        {
            get { return _vectorParams; }
        }
        public string TypeIris
        {
            get { return _typeIris; }
        }
        public double SepalLength
        {
            get { return _vectorParams[0]; }
        }
        public double SepalWidth
        {
            get { return _vectorParams[1]; }
        }
        public double PetalLength
        {
            get { return _vectorParams[2]; }
        }
        public double PetalWidth
        {
            get { return _vectorParams[3]; }
        }
        public override string ToString()
        {
            return $"{_vectorParams}, {_typeIris}";
        }
    }
}
