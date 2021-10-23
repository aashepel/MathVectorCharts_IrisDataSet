using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts
{
    /// <summary>
    /// Дата-сет ирисов из файла
    /// </summary>
    public class IrisesDataSet
    {
        /// <summary>
        /// Список дата-сетов ирисов.
        /// Дата-сеты выделены по признаку типа ириса
        /// </summary>
        private List<ConcreteTypeIrisDataSet> _arrayConcreteTypeIrisDataSet;

        /// <summary>
        /// Конструктор
        /// </summary>
        public IrisesDataSet()
        {
            _arrayConcreteTypeIrisDataSet = new List<ConcreteTypeIrisDataSet>();
        }

        /// <summary>
        /// Свойство для списка дата-сетов
        /// </summary>
        public List<ConcreteTypeIrisDataSet> ArrayConcreteTypeIrisDataSet
        {
            get { return _arrayConcreteTypeIrisDataSet; }
        }

        /// <summary>
        /// Метод для добавления ириса в дата-сет
        /// </summary>
        /// <param name="iris">Ирис</param>
        public void Add(Iris iris)
        {
            // Если тип переданного ириса ранее не встречался
            if (!ContainType(iris.TypeIris))
            {
                // Создаем новый дата-сет под конкретный тип ирисов
                var dataSetConcreteIris = new ConcreteTypeIrisDataSet(iris.TypeIris);
                // Добавляем его в список всех дата-сетов
                _arrayConcreteTypeIrisDataSet.Add(dataSetConcreteIris);
                // Добавляем ирис в созданный ранее дата-сет
                dataSetConcreteIris.Add(iris);
            }
            else
            {
                // Если тип таких ирисов встречался ранее,
                // то делаем попытку добавить ирис в дата-сет, предназначенный для такого типа ирисов
                _arrayConcreteTypeIrisDataSet.FirstOrDefault(p => p.Type == iris.TypeIris)
                    ?.Add(iris);
            }
        }

        /// <summary>
        /// Метод для проверки наличия дата-сет под конкретный тип ириса
        /// </summary>
        /// <param name="typeIris">Тип ириса</param>
        /// <returns></returns>
        private bool ContainType(string typeIris)
        {
            var dataSetConcreteIris = _arrayConcreteTypeIrisDataSet.FirstOrDefault(p => p.Type == typeIris);
            if (dataSetConcreteIris == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Метод для очистки всех дата-сетов
        /// </summary>
        public void Clear()
        {
            _arrayConcreteTypeIrisDataSet.Clear();
        }
        public override string ToString()
        {
            string result = "";
            foreach (var typeIris in _arrayConcreteTypeIrisDataSet)
            {
                result += typeIris;
            }
            return result;
        }
    }
}
