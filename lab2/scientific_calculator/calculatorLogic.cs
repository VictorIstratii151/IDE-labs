using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
