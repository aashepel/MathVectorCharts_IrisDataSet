using MathVectorCharts.Domain.Exceptions;
using MathVectorCharts.Infrastucture.Persistence.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace MathVectorCharts.Infrastucture.Persistence.Parsers
{
    public abstract class BaseParser<T> : IParser<T> where T : class
    {
        private string _filePath;
        private int _maxSizeFile;
        public BaseParser(string filePath, int maxSizeFile = 1024 * 1024)
        {
            _maxSizeFile = maxSizeFile;
            var fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                throw new NotExsistFileException();
            }
            if (fileInfo.Length > _maxSizeFile)
            {
                throw new ExceededAllowedFileLengthException();
            }
            _filePath = filePath;
        }
        public abstract List<T> GetRecords();
        public virtual string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
    }
}
