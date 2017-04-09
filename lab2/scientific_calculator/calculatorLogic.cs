using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculatorLogic
{
    class BusinessLogic
    {
        public static double addDoubles(double d1, double d2)
        {
            return d1 + d2;
        }

        public static double subtractDoubles(double d1, double d2)
        {
            return d1 - d2;
        }

        public static double multiplyDoubles(double d1, double d2)
        {
            return d1 * d2;
        }

        public static double divideDoubles(double d1, double d2)
        {
            return d1 / d2;
        }

        public static double modDoubles(double d1, double d2)
        {
            return d1 % d2;
        }

        public static string backspace(TextBox txt)
        {
            if (txt.Text.Length > 0)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
            }

            if (txt.Text == "")
            {
                txt.Text = "0";
            }

            return txt.Text;
        }

        public static string CE(TextBox txt)
        {
            return "0";
        }
        
        public static void Clear(TextBox txt, Label lbl)
        {
            txt.Text = "0";
            lbl.Text = "";
        }

        public static double PlusMinus(double d1)
        {
            return -1 * d1;
        }

        public static double Power(double d1, double d2)
        {
            return Math.Pow(d1, d2);
        }

        public static double Exp(double d1)
        {
            return Math.Exp(d1);
        }

        public static double Pi()
        {
            return Math.PI;
        }
        
        public static double Log10(double d1)
        {
            return Math.Log10(d1);
        }

        public static double Ln(double d1)
        {
            return Math.Log(d1);
        }

        public static double Sqrt(double d1)
        {
            return Math.Sqrt(d1);
        }

        public static double Sin(double d1)
        {
            return Math.Sin(d1);
        }

        public static double Sinh(double d1)
        {
            return Math.Sinh(d1);
        }

        public static double Cos(double d1)
        {
            return Math.Cos(d1);
        }

        public static double Cosh(double d1)
        {
            return Math.Cosh(d1);
        }

        public static double Tan(double d1)
        {
            return Math.Tan(d1);
        }

        public static double Tanh(double d1)
        {
            return Math.Tanh(d1);
        }

        public static string toDec(TextBox txt)
        {
            int a = int.Parse(txt.Text);

            return System.Convert.ToString(a, 10);
        }

        public static string toBin(TextBox txt)
        {
            int a = int.Parse(txt.Text);

            return System.Convert.ToString(a, 2);
        }

        public static string toOct(TextBox txt)
        {
            int a = int.Parse(txt.Text);

            return System.Convert.ToString(a, 8);
        }

        public static string toHex(TextBox txt)
        {
            int a = int.Parse(txt.Text);

            return System.Convert.ToString(a, 16);
        }

        public static double Pow2(TextBox txt)
        {
            double a = Double.Parse(txt.Text);

            return a * a;
        }

        public static double Pow3(TextBox txt)
        {
            double a = Double.Parse(txt.Text);

            return a * a * a;
        }

        public static double oneOver(TextBox txt)
        {
            double a = Double.Parse(txt.Text);

            return 1 / a;
        }

    }
}
