﻿namespace MathVectorCharts
{
    partial class Form1
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
            this.chart_sepal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_openFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).BeginInit();
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
            this.button_openFile.Location = new System.Drawing.Point(12, 318);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(122, 23);
            this.button_openFile.TabIndex = 4;
            this.button_openFile.Text = "Open CSV file";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 450);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.chart_petal_width);
            this.Controls.Add(this.chart_petal_length);
            this.Controls.Add(this.chart_sepal_width);
            this.Controls.Add(this.chart_sepal_length);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_width;
        private System.Windows.Forms.Button button_openFile;
    }
}
