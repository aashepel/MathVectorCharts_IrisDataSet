using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathVectorCharts.Exceptions
{
    public class NotExsistFileException : BaseMathVectorChartsException
    {
        private const string _description = "Файл по указанному пути не существует";
        public override string Description
        {
            get { return _description; }
        }
    }
}
