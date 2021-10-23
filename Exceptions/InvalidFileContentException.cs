using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Exceptions
{
    internal class InvalidFileContentException : BaseMathVectorChartsException
    {
        public InvalidFileContentException()
        {

        }
        public InvalidFileContentException(string description)
        {
            _description = description;
        }
        private string _description = "Данные в файле повреждены или имеют неверный формат";
        public override string Description
        { 
            get { return _description; }
        }
    }
}
