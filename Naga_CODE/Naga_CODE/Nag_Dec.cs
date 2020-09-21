using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naga_CODE
{
    class Nag_Dec
    {
        public static int Nag2toDec(string neg)
        {
            var res = Convert.ToInt32(neg[0].ToString());
            for (int i = 1; i < neg.Length; i++)
            {
                res = -2 * res + Convert.ToInt32(neg[i].ToString());
            }
            return res;
        }


        public static string DecToNeg2(int number)
        {
            if (number == 1 || number == 0)
            {
                return number.ToString();
            }
            return DecToNeg2(Div(number, -2)) + Mod(number, -2);
        }

        private static int Div(int x, int y)
        {
            return x % y < 0 ? (x - Math.Abs(x % y)) / y : x / y;
        }

        private static int Mod(int x, int y)
        {
            return x - y * Div(x, y);
        }


    }
}
