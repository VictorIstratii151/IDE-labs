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

    }
}
