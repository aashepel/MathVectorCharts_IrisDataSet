using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts
{
    public class ConcreteTypeIrisDataSet
    {
        /// <summary>
        /// Список ирисов ОДНОГО типа
        /// </summary>
        private List<Iris> _irises;

        /// <summary>
        /// Конструкор
        /// </summary>
        /// <param name="type">Тип ириса</param>
        public ConcreteTypeIrisDataSet(string type)
        {
            _irises = new List<Iris>();
            Type = type;
        }

        /// <summary>
        /// Авто-свойство для типа ириса
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Свойство для получения списка ирисов
        /// </summary>
        public List<Iris> Irises
        {
            get { return _irises; }
        }

        /// <summary>
        /// Метод для добавления ириса в дата-сет
        /// </summary>
        /// <param name="iris"></param>
        public void Add(Iris iris)
        {
            _irises.Add(iris);
        }

        /// <summary>
        /// Метод для вычисления усредненного вектора
        /// </summary>
        /// <returns>Усредненный математический вектор</returns>
        public MathVector ArithmeticMeanVector()
        {
            List<double> arithmeticMeansValues = new List<double>();
            for (int i = 0; i < 4; i++)
            {
                arithmeticMeansValues.Add(ArithmeticMeanOfColumn(i));
            }
            MathVector vector = new MathVector(arithmeticMeansValues.ToArray());
            return vector;
        }

        /// <summary>
        /// Метод для вычисления среднего арифмитического значения по определенному столбцу списка векторов
        /// </summary>
        /// <param name="indexColumn">Индекс столбца. Нумерация с нуля</param>
        /// <returns>Среднее арифмитическое значение</returns>
        public double ArithmeticMeanOfColumn(int indexColumn)
        {
            double sum = 0;
            int counter = 0;
            foreach(Iris iris in _irises)
            {
                sum += iris.VectorParams[indexColumn];
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
