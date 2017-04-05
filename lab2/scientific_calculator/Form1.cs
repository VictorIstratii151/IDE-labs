using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientific_calculator
{
    public partial class Calculator : Form
    {
        Double results = 0;
        String operation = "";
        bool enterValue = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtDisplay.TextAlign = HorizontalAlignment.Right;
        }

        private void bckSpcBtn(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";

            switch(operation)
            {
                case "+":
                    {
                        txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;

                case "-":
                    {
                        txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;

                case "*":
                    {
                        txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;

                case "/":
                    {
                        txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;

                case "Pow":
                    {
                        txtDisplay.Text = Math.Pow(results, Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;

                case "%":
                    {
                        txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 275;
            txtDisplay.Width = 230;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if((txtDisplay.Text == "0") || (enterValue))
            {
                txtDisplay.Text = "";
            }

            enterValue = false;
            Button num = (Button)sender;

            if(num.Text == ".")
            {
                if(!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += num.Text;
                }
            }
            else
            {
                txtDisplay.Text += num.Text;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCE(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShow.Text = "";
        }

        private void ArithmeticOperation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShow.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void btnPlusMinus(object sender, EventArgs e)
        {
            results = (-1) * (Double.Parse(txtDisplay.Text));
            lblShow.Text = "(" + System.Convert.ToString(results) + ")";
            txtDisplay.Text = System.Convert.ToString(results);
        }

        private void btnExp(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblShow.Text = operation + "(" + System.Convert.ToString(results) + ")";
            txtDisplay.Text = System.Convert.ToString(Math.Exp(results));

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = System.Convert.ToString(3.1415926535899);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 275;
            txtDisplay.Width = 230;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            txtDisplay.Width = 485;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            double ilog = Double.Parse(txtDisplay.Text);
            lblShow.Text = operation + "10 (" + System.Convert.ToString(ilog) + ")";
            ilog = Math.Log10(ilog);
            txtDisplay.Text = "0";
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShow.Text = "ln (" + System.Convert.ToString(ilog) + ")";
            ilog = Math.Log(ilog);
            txtDisplay.Text = "0";
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double isqrt = Double.Parse(txtDisplay.Text);
            lblShow.Text = System.Convert.ToString("sqrt(" + (txtDisplay.Text) + ")");
            isqrt = Math.Sqrt(isqrt);
            txtDisplay.Text = "0";
            txtDisplay.Text = System.Convert.ToString(isqrt);
        }

        private void TrigonOperation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            lblShow.Text = "";
            switch(operation)
            {
                case "Sin":
                    {
                        lblShow.Text = System.Convert.ToString("sin(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Sin(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;

                case "Cos":
                    {
                        lblShow.Text = System.Convert.ToString("cos(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Cos(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;

                case "Sinh":
                    {
                        lblShow.Text = System.Convert.ToString("sinh(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Sinh(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;

                case "Cosh":
                    {
                        lblShow.Text = System.Convert.ToString("cosh(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Cosh(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;

                case "Tan":
                    {
                        lblShow.Text = System.Convert.ToString("tan(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Tan(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;

                case "Tanh":
                    {
                        lblShow.Text = System.Convert.ToString("tanh(" + (txtDisplay.Text) + ")");
                        results = Double.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString((Math.Tanh(Double.Parse(txtDisplay.Text)).ToString()));
                    }
                    break;
            }
            //txtDisplay.Text = "";
            //lblShow.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void ConvertOperation(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            lblShow.Text = "";
            //int a = int.Parse(txtDisplay.Text);

            switch(operation)
            {
                case "Dec":
                    {
                        int a = int.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString(a, 10);
                    }
                    break;

                case "Bin":
                    {
                        int a = int.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString(a, 2);
                    }
                    break;

                case "Hex":
                    {
                        int a = int.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString(a, 16);
                    }
                    break;

                case "Oct":
                    {
                        int a = int.Parse(txtDisplay.Text);
                        txtDisplay.Text = System.Convert.ToString(a, 8);
                    }
                    break;
            }
        }

        private void btnPow2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btnPow3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void btn1overX_Click(object sender, EventArgs e)
        {
            double a = 1 / Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}
