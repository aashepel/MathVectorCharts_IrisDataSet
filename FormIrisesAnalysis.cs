using LinearAlgebra;
using MathVectorCharts.Exceptions;
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
using MessageBox = System.Windows.Forms.MessageBox;

namespace MathVectorCharts
{
    public partial class FormIrisesAnalysis : Form
    {
        private LogicLayer _logicLayer;
        private List<Chart> _barCharts = new List<Chart>();
        public FormIrisesAnalysis()
        {
            InitializeComponent();
            _logicLayer = new LogicLayer();
            // Порядок добавления важен !!!!
            _barCharts.Add(chart_petal_length);
            _barCharts.Add(chart_petal_width);
            _barCharts.Add(chart_sepal_length);
            _barCharts.Add(chart_sepal_width);
            ClearAllCharts();
            ResetLabelFilePath();
        }
        /// <summary>
        /// Метод для отображения сообщения
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="icon">Отображаемая иконка</param>
        /// <param name="title">Заголовок сообщения</param>
        private void ShowMessageWindow(string text, MessageBoxIcon icon, string title = "Сообщение")
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Метод для очистки диаграммы
        /// </summary>
        /// <param name="chart">Диаграмма</param>
        private static void ClearChart(Chart chart)
        {
            chart.Series.Clear();
            chart.Legends.Clear();
            chart.Titles.Clear();
        }

        /// <summary>
        /// Метод для очистки всех диаграмм
        /// </summary>
        private void ClearAllCharts()
        {
            foreach (Chart chart in _barCharts)
            {
                ClearChart(chart);
            }
            ClearChart(pieChart);
        }

        /// <summary>
        /// Метод для сброса строки с путем файла
        /// </summary>
        private void ResetLabelFilePath()
        {
            label_pathFile.Text = "Файл не загружен";
        }

        /// <summary>
        /// Метод для сброса состояния программы
        /// </summary>
        private void ResetStateProgram()
        {
            ClearAllCharts();
            _logicLayer.Reset();
            ResetLabelFilePath();
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
                label_pathFile.Text = $"Путь к файлу: {_logicLayer.FilePath}";
                try
                {
                    _logicLayer.ReadFile();
                    ShowMessageWindow("Чтение файла выполнено успешно", MessageBoxIcon.Information);
                    RenderCharts();
                }
                catch (BaseMathVectorChartsException ex)
                {
                    ShowMessageWindow(ex.Description, MessageBoxIcon.Error);
                    ResetLabelFilePath();
                    _logicLayer.Reset();
                }
            }
        }

        /// <summary>
        /// Метод для отрисовки диаграмм
        /// </summary>
        private void RenderCharts()
        {
            // Получаем уникальный список ирисов из дата-сетов
            List<string> typesIrises = new List<string>(_logicLayer.DataSet.ArrayConcreteTypeIrisDataSet.Select(p => p.Type));
            // Делаем цикл для заполнения всех столбчатых диаграмм
            for (int i = 0; i < _barCharts.Count; i++)
            {
                // Очищаем заголовок текущей диаграммы
                _barCharts[i].Titles.Clear();
                // Добавляем заголовок диаграммы. Значение берем из статического свойства получения допустимых свойств ирисов
                _barCharts[i].Titles.Add(Iris.PossibleNameOfParams[i]);
                // Убираем ось X
                _barCharts[i].ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                // Включаем 3D
                _barCharts[i].ChartAreas[0].Area3DStyle.Enable3D = true;
                // Выставляем угол поворота диаграммы
                _barCharts[i].ChartAreas[0].Area3DStyle.Rotation = 50;
                // Получаем ссылку на коллекцию серий текущей диаграммы
                var seriesCurrentChart = _barCharts[i].Series;
                // Очищаем все серии из коллекции
                seriesCurrentChart.Clear();
                for (int j = 0; j < typesIrises.Count; j++)
                {
                    // Добавляем новую серию на диаграмму
                    Series addedSeries = seriesCurrentChart.Add(typesIrises[j]);
                    // Получаем ссылку на дата-сет конкретного типа ирисов
                    ConcreteTypeIrisDataSet concreteTypeIrisDataSet = _logicLayer.DataSet.ArrayConcreteTypeIrisDataSet.FirstOrDefault(p => p.Type == typesIrises[j]);
                    if (concreteTypeIrisDataSet != null)
                    {
                        // Вычисляем среднее арифм. для нужного столбца дата-сета и округляем его для удобства
                        double addingValue = Math.Round(concreteTypeIrisDataSet.ArithmeticMeanOfColumn(i), 2);
                        // Добавляем точку на серию
                        addedSeries.Points.Add(addingValue);
                        // Выставляем свойство, чтобы сверху столбчатых диаграмм отображалось значение
                        addedSeries.IsValueShownAsLabel = true;
                        // Значение, отображаемое сверху от столбцов
                        addedSeries.Label = addingValue.ToString();
                        // Заносим тип ириса в легенду текущей диаграммы
                        _barCharts[i].Legends.Add(typesIrises[j]);
                        // Делаем столбики в виде цилиндров
                        addedSeries["DrawingStyle"] = "Cylinder";
                    }
                }
            }
            // Очищаем серии круговой диаграммы
            pieChart.Series.Clear();
            // Вычисляем усредненные вектора для каждого типа ирисов
            List<Iris> meanIrisesOfTypeArray = new List<Iris>();
            // Делаем усредненный вектор и ирис для каждого типа ирисов
            foreach(var type in typesIrises)
            {
                // Получаем конкретный дата-сет ирисов одного типа
                ConcreteTypeIrisDataSet concreteTypeIrisDataSet = _logicLayer.DataSet.ArrayConcreteTypeIrisDataSet.FirstOrDefault(p => p.Type == type);
                // Если такой дата-сет существует
                if (concreteTypeIrisDataSet != null)
                {
                    // Делаем усредненный вектор
                    MathVector currentMeanVector = concreteTypeIrisDataSet.ArithmeticMeanVector();
                    // Делаем усредненный ирис
                    Iris currentMeanIris = new Iris(currentMeanVector, type);
                    // Добавляем его в список
                    meanIrisesOfTypeArray.Add(currentMeanIris);
                }
            }
            // Включаем 3D
            pieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            // Добавляем серию с произвольным названием
            Series addedSeriesPieChart = pieChart.Series.Add("s1");
            // Очищаем все точки
            addedSeriesPieChart.Points.Clear();
            // Устанавливаем тип диаграммы - круговая
            addedSeriesPieChart.ChartType = SeriesChartType.Pie;
            // Перебираем все неповторяющиеся комбинации из двух векторов
            for (int i = 0, counterPie = 0; i < meanIrisesOfTypeArray.Count; i++)
            {
                for (int j = i + 1; j < meanIrisesOfTypeArray.Count; j++, counterPie++)
                {
                    // Усредненный ирис 1
                    Iris currentIrisFirst = meanIrisesOfTypeArray[i];
                    // Усредненный ирис 2
                    Iris currentIrisSecond = meanIrisesOfTypeArray[j];
                    // Составляем заголовок кусочка для дальнейшего занесения в легенду
                    string currentLabelPie = currentIrisFirst.TypeIris.ToUpper() + " & " + currentIrisSecond.TypeIris.ToUpper();
                    // Вычисляем Евклидово расстояние
                    double currentDistanceBetweenVectors = Math.Round(currentIrisFirst.VectorParams.CalcDistance(currentIrisSecond.VectorParams), 2);
                    // Добавляем точку и сразу получаем ее индекс в серии
                    int indexAddedSeries = addedSeriesPieChart.Points.AddY(currentDistanceBetweenVectors);
                    // Добавляем новую подпись для легенды
                    pieChart.Legends.Add(currentLabelPie);
                    // Подпись на самом кусочке в формате |значение (процент)|
                    addedSeriesPieChart.Points[indexAddedSeries].Label = "#VALY (#PERCENT)";
                    // Делаем подпись на легенде
                    addedSeriesPieChart.Points[indexAddedSeries].LegendText = currentLabelPie;
                }
            }
        }

        private void button_reset_state_Click(object sender, EventArgs e)
        {
            ResetStateProgram();
        }
    }
}
