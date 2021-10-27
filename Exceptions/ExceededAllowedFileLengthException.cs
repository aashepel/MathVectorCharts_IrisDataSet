using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Exceptions
{
    public class ExceededAllowedFileLengthException : BaseMathVectorChartsException
    {
        private const string _descritpion = "Превышен допустимый размер файла";
        public override string Description
        {
            get { return _descritpion; }
        }
    }
}
