using MathVectorCharts.Domain.Entities;
using MathVectorCharts.Infrastucture.Persistence;
using MathVectorCharts.Infrastucture.Persistence.Interfaces;
using MathVectorCharts.Infrastucture.Persistence.Parsers;

namespace MathVectorCharts.Presentation
{
    public class LogicLayerFacade
    {
        /// <summary>
        /// Дата-сет ирисов
        /// </summary>
        private IrisesDataSet _dataSet;
        private ICsvParser<Iris> _csvParser;
        private string _filePath;

        /// <summary>
        /// Конструктор
        /// </summary>
        public LogicLayerFacade(string filePath)
        {
            _filePath = filePath;
            _dataSet = new IrisesDataSet();
        }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Свойство для получения или присвоения Дата-сета
        /// </summary>
        public IrisesDataSet DataSet
        {
            get { return _dataSet; }
            set { _dataSet = value; }
        }

        public ICsvParser<Iris> Parser
        {
            get { return _csvParser; }
        }
        /// <summary>
        /// Сброс состояния класса логики
        /// </summary>
        public void Reset()
        {
            _dataSet.Clear();
        }

        public void Parse()
        {
            _csvParser = DefaultParsers.CsvParserDefault(new CsvIrisMapping(), _filePath);
            _dataSet.AddRange(_csvParser.GetRecords());
        }
    }
}
