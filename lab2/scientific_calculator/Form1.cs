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
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 275;
            txtDisplay.Width = 230;
           // txtDisplay.Text = "0";
           // lblShow.Text = "";

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
            //lblShow.Text = "";
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
    }
}
