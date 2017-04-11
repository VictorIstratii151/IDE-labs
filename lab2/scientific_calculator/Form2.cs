using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NCalc;

namespace scientific_calculator
{
    public partial class Chart_Maker : Form
    {
        double result = 0;
        string expression = "";


        public Chart_Maker()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width = 655;
            this.Height = 444;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ChartTextBox.Text.Length > 0)
            {
                expression = ChartTextBox.Text.Replace("x", "[x]");
                double i = -100;

                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

                while (i <= 100)
                {
                    Expression myExpression = new Expression(expression);
                    myExpression.Parameters["x"] = i;
                    chart1.Series["Series1"].Points.AddXY(i, myExpression.Evaluate());

                    i += 0.5;
                }
            }
            else
            {
                MessageBox.Show("The text area is empty!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Erase_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            ChartTextBox.Text = "";
        }
    }
}
