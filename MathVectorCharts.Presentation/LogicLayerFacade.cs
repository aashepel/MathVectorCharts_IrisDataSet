using System.Collections.Generic;
using TinyCsvParser;
using MathVectorCharts.Domain.Entities;
using MathVectorCharts.Infrastucture.Persistence;

namespace MathVectorCharts.Presentation
{
    public class LogicLayerFacade
    {
        /// <summary>
        /// Дата-сет ирисов
        /// </summary>
        private IrisesDataSet _dataSet;
        private IParser<Iris> _csvParser;

        /// <summary>
        /// Конструктор
        /// </summary>
        public LogicLayerFacade(string filePath)
        {
            _dataSet = new IrisesDataSet();
            _csvParser = new Infrastucture.Persistence.CsvParser<Iris>
                (new CsvParserOptions(true, ','), new CsvIrisMapping(), filePath);
        }

        public string FilePath
        {
            get { return _csvParser.FilePath; }
            set { _csvParser.FilePath = value; }
        }

        /// <summary>
        /// Свойство для получения или присвоения Дата-сета
        /// </summary>
        public IrisesDataSet DataSet
        {
            get { return _dataSet; }
            set { _dataSet = value; }
        }
        /// <summary>
        /// Сброс состояния класса логики
        /// </summary>
        public void Reset()
        {
            _dataSet.Clear();
        }

        public void ReadFile()
        {
            _dataSet.AddRange(_csvParser.GetRecords());
        }
    }
}
