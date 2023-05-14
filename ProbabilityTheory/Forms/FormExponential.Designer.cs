namespace ProbabilityTheory.Forms
{
	partial class FormExponential
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
			this.labelLambda = new System.Windows.Forms.Label();
			this.numericUpDownLambda = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownSelectionSize = new System.Windows.Forms.NumericUpDown();
			this.buttonUpdateSelection = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownIntervalsAmount = new System.Windows.Forms.NumericUpDown();
			this.labelMode = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labelMedian = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelVariance = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelExpectation = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelLambdaDistribution = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelLambdaTheory = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalsAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLambda
			// 
			this.labelLambda.AutoSize = true;
			this.labelLambda.ForeColor = System.Drawing.Color.Black;
			this.labelLambda.Location = new System.Drawing.Point(12, 11);
			this.labelLambda.Name = "labelLambda";
			this.labelLambda.Size = new System.Drawing.Size(132, 27);
			this.labelLambda.TabIndex = 10;
			this.labelLambda.Text = "Значение λ";
			// 
			// numericUpDownLambda
			// 
			this.numericUpDownLambda.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownLambda.DecimalPlaces = 1;
			this.numericUpDownLambda.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownLambda.Location = new System.Drawing.Point(149, 63);
			this.numericUpDownLambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownLambda.Name = "numericUpDownLambda";
			this.numericUpDownLambda.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownLambda.TabIndex = 9;
			this.numericUpDownLambda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(487, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 27);
			this.label1.TabIndex = 8;
			this.label1.Text = "Гистограмма";
			// 
			// chartHistogram
			// 
			this.chartHistogram.BorderSkin.BackColor = System.Drawing.Color.White;
			this.chartHistogram.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			chartArea1.Name = "ChartArea1";
			this.chartHistogram.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartHistogram.Legends.Add(legend1);
			this.chartHistogram.Location = new System.Drawing.Point(492, 46);
			this.chartHistogram.Name = "chartHistogram";
			this.chartHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartHistogram.Series.Add(series1);
			this.chartHistogram.Size = new System.Drawing.Size(630, 526);
			this.chartHistogram.TabIndex = 7;
			this.chartHistogram.Text = "chart1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(12, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 27);
			this.label4.TabIndex = 15;
			this.label4.Text = "Размер выборки";
			// 
			// numericUpDownSelectionSize
			// 
			this.numericUpDownSelectionSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownSelectionSize.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownSelectionSize.Location = new System.Drawing.Point(149, 283);
			this.numericUpDownSelectionSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownSelectionSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownSelectionSize.Name = "numericUpDownSelectionSize";
			this.numericUpDownSelectionSize.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownSelectionSize.TabIndex = 14;
			this.numericUpDownSelectionSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownSelectionSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// buttonUpdateSelection
			// 
			this.buttonUpdateSelection.BackColor = System.Drawing.Color.White;
			this.buttonUpdateSelection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonUpdateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdateSelection.Location = new System.Drawing.Point(51, 351);
			this.buttonUpdateSelection.Name = "buttonUpdateSelection";
			this.buttonUpdateSelection.Size = new System.Drawing.Size(373, 108);
			this.buttonUpdateSelection.TabIndex = 13;
			this.buttonUpdateSelection.Text = "Новая выборка";
			this.buttonUpdateSelection.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 27);
			this.label2.TabIndex = 12;
			this.label2.Text = "Количество интервалов";
			// 
			// numericUpDownIntervalsAmount
			// 
			this.numericUpDownIntervalsAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownIntervalsAmount.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownIntervalsAmount.Location = new System.Drawing.Point(149, 170);
			this.numericUpDownIntervalsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownIntervalsAmount.Name = "numericUpDownIntervalsAmount";
			this.numericUpDownIntervalsAmount.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownIntervalsAmount.TabIndex = 11;
			this.numericUpDownIntervalsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIntervalsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// labelMode
			// 
			this.labelMode.ForeColor = System.Drawing.Color.Black;
			this.labelMode.Location = new System.Drawing.Point(834, 656);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(288, 27);
			this.labelMode.TabIndex = 25;
			this.labelMode.Text = "0.000";
			this.labelMode.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(487, 656);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 27);
			this.label10.TabIndex = 24;
			this.label10.Text = "Мода";
			// 
			// labelMedian
			// 
			this.labelMedian.ForeColor = System.Drawing.Color.Black;
			this.labelMedian.Location = new System.Drawing.Point(834, 629);
			this.labelMedian.Name = "labelMedian";
			this.labelMedian.Size = new System.Drawing.Size(288, 27);
			this.labelMedian.TabIndex = 23;
			this.labelMedian.Text = "0.000";
			this.labelMedian.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(487, 629);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 27);
			this.label7.TabIndex = 22;
			this.label7.Text = "Медиана";
			// 
			// labelVariance
			// 
			this.labelVariance.ForeColor = System.Drawing.Color.Black;
			this.labelVariance.Location = new System.Drawing.Point(834, 602);
			this.labelVariance.Name = "labelVariance";
			this.labelVariance.Size = new System.Drawing.Size(288, 27);
			this.labelVariance.TabIndex = 21;
			this.labelVariance.Text = "0.000";
			this.labelVariance.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(487, 602);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 27);
			this.label8.TabIndex = 20;
			this.label8.Text = "Дисперсия";
			// 
			// labelExpectation
			// 
			this.labelExpectation.ForeColor = System.Drawing.Color.Black;
			this.labelExpectation.Location = new System.Drawing.Point(834, 575);
			this.labelExpectation.Name = "labelExpectation";
			this.labelExpectation.Size = new System.Drawing.Size(288, 27);
			this.labelExpectation.TabIndex = 19;
			this.labelExpectation.Text = "0.000";
			this.labelExpectation.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(487, 575);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(288, 27);
			this.label5.TabIndex = 18;
			this.label5.Text = "Математическое ожидание";
			// 
			// labelLambdaDistribution
			// 
			this.labelLambdaDistribution.ForeColor = System.Drawing.Color.Black;
			this.labelLambdaDistribution.Location = new System.Drawing.Point(210, 602);
			this.labelLambdaDistribution.Name = "labelLambdaDistribution";
			this.labelLambdaDistribution.Size = new System.Drawing.Size(276, 27);
			this.labelLambdaDistribution.TabIndex = 27;
			this.labelLambdaDistribution.Text = "0.000";
			this.labelLambdaDistribution.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(12, 602);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 27);
			this.label6.TabIndex = 26;
			this.label6.Text = "λ распределения";
			// 
			// labelLambdaTheory
			// 
			this.labelLambdaTheory.ForeColor = System.Drawing.Color.Black;
			this.labelLambdaTheory.Location = new System.Drawing.Point(210, 629);
			this.labelLambdaTheory.Name = "labelLambdaTheory";
			this.labelLambdaTheory.Size = new System.Drawing.Size(276, 27);
			this.labelLambdaTheory.TabIndex = 29;
			this.labelLambdaTheory.Text = "0.000";
			this.labelLambdaTheory.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(12, 629);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(192, 27);
			this.label11.TabIndex = 28;
			this.label11.Text = "λ теоретическая";
			// 
			// labelX
			// 
			this.labelX.ForeColor = System.Drawing.Color.Black;
			this.labelX.Location = new System.Drawing.Point(283, 656);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(203, 27);
			this.labelX.TabIndex = 31;
			this.labelX.Text = "0.000";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(12, 656);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(265, 25);
			this.label9.TabIndex = 30;
			this.label9.Text = "X максимального разрыва";
			// 
			// FormExponential
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 696);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.labelLambdaTheory);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.labelLambdaDistribution);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.labelMode);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.labelMedian);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelVariance);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labelExpectation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDownSelectionSize);
			this.Controls.Add(this.buttonUpdateSelection);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownIntervalsAmount);
			this.Controls.Add(this.labelLambda);
			this.Controls.Add(this.numericUpDownLambda);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chartHistogram);
			this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormExponential";
			this.Text = "FormExponential";
			this.Load += new System.EventHandler(this.FormExponential_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalsAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLambda;
		private System.Windows.Forms.NumericUpDown numericUpDownLambda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownSelectionSize;
		private System.Windows.Forms.Button buttonUpdateSelection;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownIntervalsAmount;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelMedian;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelVariance;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelExpectation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelLambdaDistribution;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelLambdaTheory;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label label9;
	}
}