﻿namespace scientific_calculator
{
    partial class Chart_Maker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTextBox = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(445, 382);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ChartTextBox
            // 
            this.ChartTextBox.Location = new System.Drawing.Point(463, 12);
            this.ChartTextBox.Multiline = true;
            this.ChartTextBox.Name = "ChartTextBox";
            this.ChartTextBox.Size = new System.Drawing.Size(164, 49);
            this.ChartTextBox.TabIndex = 1;
            this.ChartTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(463, 67);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(75, 23);
            this.Plot.TabIndex = 2;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
            this.Plot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(552, 67);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(75, 23);
            this.Erase.TabIndex = 3;
            this.Erase.Text = "Erase";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // Chart_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 406);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.ChartTextBox);
            this.Controls.Add(this.chart1);
            this.Name = "Chart_Maker";
            this.Text = "Plot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox ChartTextBox;
        private System.Windows.Forms.Button Plot;
        private System.Windows.Forms.Button Erase;
    }
}