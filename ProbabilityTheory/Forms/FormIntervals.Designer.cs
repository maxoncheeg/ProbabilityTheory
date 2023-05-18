namespace ProbabilityTheory.Forms
{
	partial class FormIntervals
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.numericUpDownExpectation = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownDeviation = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.chartHistogramBig = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartHistogramSmall = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpectation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeviation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogramBig)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogramSmall)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownExpectation
			// 
			this.numericUpDownExpectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownExpectation.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownExpectation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownExpectation.Location = new System.Drawing.Point(410, 70);
			this.numericUpDownExpectation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownExpectation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownExpectation.Name = "numericUpDownExpectation";
			this.numericUpDownExpectation.Size = new System.Drawing.Size(232, 38);
			this.numericUpDownExpectation.TabIndex = 5;
			this.numericUpDownExpectation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownExpectation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(669, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 56);
			this.label1.TabIndex = 8;
			this.label1.Text = "Среднеквадратичное отклонение";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// numericUpDownDeviation
			// 
			this.numericUpDownDeviation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownDeviation.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownDeviation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownDeviation.Location = new System.Drawing.Point(674, 70);
			this.numericUpDownDeviation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownDeviation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownDeviation.Name = "numericUpDownDeviation";
			this.numericUpDownDeviation.Size = new System.Drawing.Size(232, 38);
			this.numericUpDownDeviation.TabIndex = 7;
			this.numericUpDownDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownDeviation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(405, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 56);
			this.label3.TabIndex = 9;
			this.label3.Text = "Математическое ожидание";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.BackColor = System.Drawing.Color.White;
			this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCalculate.Location = new System.Drawing.Point(410, 116);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(496, 75);
			this.buttonCalculate.TabIndex = 10;
			this.buttonCalculate.Text = "Рассчитать доверительные интервалы";
			this.buttonCalculate.UseVisualStyleBackColor = false;
			// 
			// chartHistogramBig
			// 
			this.chartHistogramBig.BorderSkin.BackColor = System.Drawing.Color.White;
			this.chartHistogramBig.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			chartArea1.Name = "ChartArea1";
			this.chartHistogramBig.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartHistogramBig.Legends.Add(legend1);
			this.chartHistogramBig.Location = new System.Drawing.Point(12, 213);
			this.chartHistogramBig.Name = "chartHistogramBig";
			this.chartHistogramBig.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartHistogramBig.Series.Add(series1);
			this.chartHistogramBig.Size = new System.Drawing.Size(630, 526);
			this.chartHistogramBig.TabIndex = 11;
			this.chartHistogramBig.Text = "chart1";
			// 
			// chartHistogramSmall
			// 
			this.chartHistogramSmall.BorderSkin.BackColor = System.Drawing.Color.White;
			this.chartHistogramSmall.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			chartArea2.Name = "ChartArea1";
			this.chartHistogramSmall.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartHistogramSmall.Legends.Add(legend2);
			this.chartHistogramSmall.Location = new System.Drawing.Point(679, 213);
			this.chartHistogramSmall.Name = "chartHistogramSmall";
			this.chartHistogramSmall.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartHistogramSmall.Series.Add(series2);
			this.chartHistogramSmall.Size = new System.Drawing.Size(630, 526);
			this.chartHistogramSmall.TabIndex = 12;
			this.chartHistogramSmall.Text = "chart1";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(13, 172);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(237, 38);
			this.label2.TabIndex = 13;
			this.label2.Text = "N=500";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(1072, 172);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 38);
			this.label4.TabIndex = 14;
			this.label4.Text = "N=50";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormIntervals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 748);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chartHistogramSmall);
			this.Controls.Add(this.chartHistogramBig);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownDeviation);
			this.Controls.Add(this.numericUpDownExpectation);
			this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormIntervals";
			this.Text = "Доверительные интервалы";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpectation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeviation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogramBig)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogramSmall)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.NumericUpDown numericUpDownExpectation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownDeviation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogramBig;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogramSmall;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}