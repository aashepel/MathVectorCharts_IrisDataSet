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
        private IrisesDataSet _dataSet;
        public string FilePath { get; set; }
        public LogicLayer()
        {
            _dataSet = new IrisesDataSet();
        }
        public IrisesDataSet DataSet
        {
            get { return _dataSet; }
            set { _dataSet = value; }
        }
        public void ReadFile()
        {
            if (!File.Exists(FilePath))
            {
                throw new NotExsistFileException();
            }
            List<string> linesFile = File.ReadAllLines(FilePath).ToList();
            linesFile.RemoveAt(0);
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            foreach (var line in linesFile)
            {
                var cellsRow = line.Split(',');
                List<double> values = new List<double>();
                for (int i = 0; i < cellsRow.Length - 1; i++)
                {
                    values.Add(Double.Parse(cellsRow[i], formatter));
                }
                var vectorParams = new MathVector(values.ToArray());
                _dataSet.Add(new Iris(vectorParams, cellsRow[cellsRow.Length - 1]));
            }
        }
    }
}
