﻿using LinearAlgebra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathVectorCharts
{
    public partial class Form1 : Form
    {
        private LogicLayer _logicLayer;
        public Form1()
        {
            InitializeComponent();
            _logicLayer = new LogicLayer();
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Файлы csv|*.csv";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _logicLayer.FilePath = openFileDialog.FileName;
                _logicLayer.ReadFile();
                RenderCharts();
            }
        }
        private void RenderCharts()
        {
            List<string> typesIrises = new List<string>(_logicLayer.DataSet.Irises.Select(p => p.Type));
            var barCharts = new List<Chart>();
            var pieChart = pie_chart;
            barCharts.Add(chart_petal_length);
            barCharts.Add(chart_petal_width);
            barCharts.Add(chart_sepal_length);
            barCharts.Add(chart_sepal_width);
            for (int i = 0; i < barCharts.Count; i++)
            {
                barCharts[i].Titles.Clear();
                barCharts[i].Titles.Add(Iris.NameOfParams[i]);
                var seriesCurrentChart = barCharts[i].Series;
                seriesCurrentChart.Clear();
                for (int j = 0; j < typesIrises.Count; j++)
                {
                    Series addedSeries = seriesCurrentChart.Add(typesIrises[j]);
                    ConcreteTypeIrisDataSet concreteTypeIrisDataSet = _logicLayer.DataSet.Irises.FirstOrDefault(p => p.Type == typesIrises[j]);
                    if (concreteTypeIrisDataSet != null)
                    {
                        addedSeries.Points.Add(concreteTypeIrisDataSet.ArithmeticMeanOfColumn(i));
                        addedSeries.IsValueShownAsLabel = true;
                    }
                }
            }
            pieChart.Series.Clear();
            Iris setosaMeanIris = new Iris(_logicLayer.DataSet.Irises.FirstOrDefault(p => p.Type == "setosa")?.ArithmeticMeanVector(), "setosa");
            Iris versicolorMeanIris = new Iris(_logicLayer.DataSet.Irises.FirstOrDefault(p => p.Type == "versicolor")?.ArithmeticMeanVector(), "versicolor");
            Iris virginicaMeanIris = new Iris(_logicLayer.DataSet.Irises.FirstOrDefault(p => p.Type == "virginica")?.ArithmeticMeanVector(), "virginica");

            List<Iris> meanVectorsArray = new List<Iris>();
            meanVectorsArray.Add(setosaMeanIris);
            meanVectorsArray.Add(versicolorMeanIris);
            meanVectorsArray.Add(virginicaMeanIris);

            Series addedSeriesPieChart = pieChart.Series.Add("s1");
            addedSeriesPieChart.Points.Clear();
            addedSeriesPieChart.ChartType = SeriesChartType.Pie;
            for (int i = 0; i < meanVectorsArray.Count; i++)
            {
                for (int j = i + 1; j < meanVectorsArray.Count; j++)
                {
                    Iris currentIrisFirst = meanVectorsArray[i];
                    Iris currentIrisSecond = meanVectorsArray[j];
                    double currentTwoIrisMean = currentIrisFirst.VectorParams.CalcDistance(currentIrisSecond.VectorParams);
                    Console.WriteLine(currentTwoIrisMean);
                    addedSeriesPieChart.Points.AddXY(currentIrisFirst.TypeIris.ToUpper() + " & " + currentIrisSecond.TypeIris.ToUpper(), currentTwoIrisMean);
                }
            }
        }
    }
}
