using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MathVectorCharts.Exceptions;
using System.Globalization;

namespace MathVectorCharts
{
    public class LogicLayer
    {
        /// <summary>
        /// Дата-сет ирисов
        /// </summary>
        private IrisesDataSet _dataSet;

        /// <summary>
        /// Содержимое файла построчно
        /// </summary>
        private List<string> _linesFile;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Указан ли путь к файлу
        /// </summary>
        private bool _pathFileSpecified;

        /// <summary>
        /// Успешно ли загружен файл
        /// </summary>
        private bool _successFileLoad;

        /// <summary>
        /// Допустимое количество столбцов в читаемом файле
        /// </summary>
        private const int acceptableСountColumn = 5;

        /// <summary>
        /// Конструктор
        /// </summary>
        public LogicLayer()
        {
            _dataSet = new IrisesDataSet();
            _linesFile = new List<string>();
            _pathFileSpecified = false;
            _successFileLoad = false;
        }

        /// <summary>
        /// Свойство
        /// </summary>
        private bool SuccessFileLoad
        {
            get { return _successFileLoad; }
        }

        /// <summary>
        /// Свойство для получения строк файла
        /// </summary>
        public List<string> LinesFile
        {
            get { return _linesFile; }
        }

        /// <summary>
        /// Свойство пути файла
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                _pathFileSpecified = true;
            }
        }

        /// <summary>
        /// Свойство для получения инфорамции о том, загружен файл или нет
        /// </summary>
        /// 
        public bool PathFileSpecified
        {
            get { return _pathFileSpecified; }
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
            _linesFile.Clear();
            _pathFileSpecified = false;
            _successFileLoad = false;
        }

        /// <summary>
        /// Чтение и проверка .csv файла
        /// </summary>
        /// <exception cref="NotExsistFileException">Бросается исключение, если по указанному пути не существует файла</exception>
        /// <exception cref="InvalidFileContentException">Бросается исключение, если содержимое файла не удовлетворяет требованиям программы</exception>
        public void ReadFile()
        {
            try
            {
                // Перед чтением файла очищаем дата-сет
                _dataSet.Clear();
                FileInfo fileInfo = new FileInfo(FilePath);
                // Проверяем существует ли файл
                if (!fileInfo.Exists)
                {
                    throw new NotExsistFileException();
                }
                // Провереяем размер файла. Он не должен быть больше 1 МБ
                if (fileInfo.Length > 1048576)
                {
                    new ExceededAllowedFileLengthException();
                }
                // Список строк файла
                List<string> linesFile = new List<string>(File.ReadAllLines(FilePath));
                _linesFile = new List<string>(linesFile);
                // Если строк в файле меньше двух пробрасываем исключение
                if (linesFile.Count < 2)
                {
                    throw new InvalidFileContentException();
                }
                // Заголовки столбцов в таблице (sepal_length,sepal_width,petal_length,petal_width,species)
                List<string> headersOfColumns = linesFile.ElementAt(0).Split(',').ToList();
                // Проверяем правильно ли названы заголовки в файле
                CheckCorrectnessHeaders(headersOfColumns);
                // Удалеям первую строчку, так как это заголовки столбцов (при заполнении дата-сета эта строка не нужна)
                linesFile.RemoveAt(0);
                // Выполняем перебор всех строк
                foreach (var line in linesFile)
                {
                    // Разделяем текущую строку на ячейки
                    List<string> cellsRow = line.Split(',').ToList();
                    // Если количество ячеек не соответсвует допустимому, бросаем исключение
                    if (cellsRow.Count != acceptableСountColumn)
                    {
                        throw new InvalidFileContentException();
                    }
                    // Получаем текущий тип ириса из последней ячейки строки
                    string currentIrisType = cellsRow.Last();
                    // Удаляем последнюю ячейку строки, так как она отвечает за тип ириса (в математическом векторе этот параметр не нужен)
                    cellsRow.RemoveAt(cellsRow.Count - 1);
                    // Ячейки строки представляем как Double для дальнейшего удобства создания математического вектора
                    List<double> values = ParametersOfRowsToDoubleArray(cellsRow);
                    // Создаем математичекский вектор на основе параметров, взятых их текущей строки файла
                    var vectorParams = new MathVector(values.ToArray());
                    // Добавляем в дата-сет новый ирис, который создаем на основе вектора и типа, взятого из последней ячейки строки
                    _dataSet.Add(new Iris(vectorParams, currentIrisType));
                }
            }
            catch
            {
                // Из-за ошибки при чтении файла сбрасываем состояние уровня логики
                Reset();
                // Пробрасываем исключение на уровень выше (в класс Формы)
                throw;
            }
            _successFileLoad = true;
        }

        /// <summary>
        /// Проверка
        /// </summary>
        /// <param name="headers">Список заголовков таблицы</param>
        /// <exception cref="InvalidFileContentException"></exception>
        private void CheckCorrectnessHeaders(List<string> headers)
        {
            // Если количество заголовков не соответствует ожидаемому числу, то бросаем исключение,
            if (headers.Count != acceptableСountColumn)
            {
                throw new InvalidFileContentException();
            }
            // Перебираем все заголовки столбцов переданного файла
            foreach (var title in headers)
            {
                // Если текущий заголовок не соответсвует одному из допустимых, бросаем исключение
                if (!Iris.PossibleNameOfParams.Contains(title))
                {
                    throw new InvalidFileContentException();
                }
            }
        }

        /// <summary>
        /// Преобразование всех параметров ириса из ячеек строки в массив Double
        /// </summary>
        /// <param name="cellsRow">Ячейки строки</param>
        /// <returns>Массив значений параметров ириса</returns>
        /// <exception cref="InvalidFileContentException">Бросается исключение, если содержимое файла не удовлетворяет требованиям программы</exception>
        private List<double> ParametersOfRowsToDoubleArray(List<string> cellsRow)
        {
            List<double> values = new List<double>();
            // Форматтер для правильного отделения целой и дробной части в Double числах
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            for (int i = 0; i < cellsRow.Count; i++)
            {
                // Готовимся к перехвату исключений, если при парсинге ячеек что-то пойдет не так
                try
                {
                    values.Add(Double.Parse(cellsRow[i], formatter));
                }
                // Если возникает исключение, пробрасываем "свое" исключение о некорректности файла
                catch (Exception exception)
                {
                    throw new InvalidFileContentException(exception.Message);
                }
            }
            return values;
        }
    }
}
