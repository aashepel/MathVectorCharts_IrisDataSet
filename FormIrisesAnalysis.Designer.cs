namespace MathVectorCharts
{
    partial class FormIrisesAnalysis
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_sepal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_openFile = new System.Windows.Forms.Button();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_pathFile = new System.Windows.Forms.Label();
            this.button_reset_state = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_sepal_length
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_sepal_length.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_sepal_length.Legends.Add(legend1);
            this.chart_sepal_length.Location = new System.Drawing.Point(12, 12);
            this.chart_sepal_length.Name = "chart_sepal_length";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_sepal_length.Series.Add(series1);
            this.chart_sepal_length.Size = new System.Drawing.Size(300, 300);
            this.chart_sepal_length.TabIndex = 0;
            this.chart_sepal_length.Text = "chart1";
            // 
            // chart_sepal_width
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_sepal_width.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_sepal_width.Legends.Add(legend2);
            this.chart_sepal_width.Location = new System.Drawing.Point(318, 12);
            this.chart_sepal_width.Name = "chart_sepal_width";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_sepal_width.Series.Add(series2);
            this.chart_sepal_width.Size = new System.Drawing.Size(300, 300);
            this.chart_sepal_width.TabIndex = 1;
            this.chart_sepal_width.Text = "chart1";
            // 
            // chart_petal_length
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_petal_length.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_petal_length.Legends.Add(legend3);
            this.chart_petal_length.Location = new System.Drawing.Point(624, 12);
            this.chart_petal_length.Name = "chart_petal_length";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_petal_length.Series.Add(series3);
            this.chart_petal_length.Size = new System.Drawing.Size(300, 300);
            this.chart_petal_length.TabIndex = 2;
            this.chart_petal_length.Text = "chart1";
            // 
            // chart_petal_width
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_petal_width.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_petal_width.Legends.Add(legend4);
            this.chart_petal_width.Location = new System.Drawing.Point(930, 12);
            this.chart_petal_width.Name = "chart_petal_width";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_petal_width.Series.Add(series4);
            this.chart_petal_width.Size = new System.Drawing.Size(300, 300);
            this.chart_petal_width.TabIndex = 3;
            this.chart_petal_width.Text = "chart1";
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(624, 318);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(300, 48);
            this.button_openFile.TabIndex = 4;
            this.button_openFile.Text = "Open CSV file";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // pieChart
            // 
            chartArea5.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.pieChart.Legends.Add(legend5);
            this.pieChart.Location = new System.Drawing.Point(12, 314);
            this.pieChart.Name = "pieChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.pieChart.Series.Add(series5);
            this.pieChart.Size = new System.Drawing.Size(606, 422);
            this.pieChart.TabIndex = 5;
            this.pieChart.Text = "chart1";
            // 
            // label_pathFile
            // 
            this.label_pathFile.AutoSize = true;
            this.label_pathFile.Location = new System.Drawing.Point(625, 373);
            this.label_pathFile.MinimumSize = new System.Drawing.Size(100, 0);
            this.label_pathFile.Name = "label_pathFile";
            this.label_pathFile.Size = new System.Drawing.Size(102, 13);
            this.label_pathFile.TabIndex = 6;
            this.label_pathFile.Text = "Файл не загружен";
            // 
            // button_reset_state
            // 
            this.button_reset_state.Location = new System.Drawing.Point(930, 318);
            this.button_reset_state.Name = "button_reset_state";
            this.button_reset_state.Size = new System.Drawing.Size(300, 48);
            this.button_reset_state.TabIndex = 7;
            this.button_reset_state.Text = "Reset program state";
            this.button_reset_state.UseVisualStyleBackColor = true;
            this.button_reset_state.Click += new System.EventHandler(this.button_reset_state_Click);
            // 
            // FormIrisesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1260, 762);
            this.Controls.Add(this.button_reset_state);
            this.Controls.Add(this.label_pathFile);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.chart_petal_width);
            this.Controls.Add(this.chart_petal_length);
            this.Controls.Add(this.chart_sepal_width);
            this.Controls.Add(this.chart_sepal_length);
            this.Name = "FormIrisesAnalysis";
            this.Text = "IrisesAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_width;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Label label_pathFile;
        private System.Windows.Forms.Button button_reset_state;
    }
}

