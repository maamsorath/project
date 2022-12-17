namespace DSAKnap
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Weight_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Benefit_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Exit_Lbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Benefit_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Weight_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Weight_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Weight_Chart.Legends.Add(legend1);
            this.Weight_Chart.Location = new System.Drawing.Point(41, -1);
            this.Weight_Chart.Name = "Weight_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Benifit";
            this.Weight_Chart.Series.Add(series1);
            this.Weight_Chart.Series.Add(series2);
            this.Weight_Chart.Size = new System.Drawing.Size(294, 287);
            this.Weight_Chart.TabIndex = 26;
            this.Weight_Chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Weight %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Benifit %";
            // 
            // Benefit_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Benefit_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Benefit_Chart.Legends.Add(legend2);
            this.Benefit_Chart.Location = new System.Drawing.Point(396, -1);
            this.Benefit_Chart.Name = "Benefit_Chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Weight";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Benifit";
            this.Benefit_Chart.Series.Add(series3);
            this.Benefit_Chart.Series.Add(series4);
            this.Benefit_Chart.Size = new System.Drawing.Size(294, 287);
            this.Benefit_Chart.TabIndex = 29;
            this.Benefit_Chart.Text = "chart2";
            // 
            // Exit_Lbl
            // 
            this.Exit_Lbl.AutoSize = true;
            this.Exit_Lbl.Location = new System.Drawing.Point(690, 323);
            this.Exit_Lbl.Name = "Exit_Lbl";
            this.Exit_Lbl.Size = new System.Drawing.Size(31, 13);
            this.Exit_Lbl.TabIndex = 30;
            this.Exit_Lbl.TabStop = true;
            this.Exit_Lbl.Text = "EXIT";
            this.Exit_Lbl.Click += new System.EventHandler(this.Exit_Lbl_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(733, 345);
            this.Controls.Add(this.Exit_Lbl);
            this.Controls.Add(this.Benefit_Chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Weight_Chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChartForm";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.Weight_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Benefit_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Weight_Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Benefit_Chart;
        private System.Windows.Forms.LinkLabel Exit_Lbl;
    }
}