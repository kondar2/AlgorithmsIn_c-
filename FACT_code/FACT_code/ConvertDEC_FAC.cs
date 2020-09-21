using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACT_code
{
    class ConvertDEC_FAC
    {

        private FACT_base _base;

        private int Radix
        {
            get
            {
                return _base.Radix;
            }
            set
            {
                _base.Radix = value;
            }
        }

        public ConvertDEC_FAC()
        {
            this._base = new FACT_base();
        }

        public int OfFactorial(int n)  //вычисляем факториал !0 = 1
        {
            return n == 0 ? 1 : n * OfFactorial(n - 1);
        }

        public int Fac2Dec(string fact)
        {
            var res = 0;
            var digit = 0; //цифра
            var length = fact.Length;

            for (int i = 0; i < fact.Length; i++)
            {
                digit = Convert.ToInt32(fact[i].ToString()); // без tostring выводит кодировку
                res += digit * OfFactorial(length--);        // используя метод ToInt32
            }
            return res;
        }


        public string Dec2Fact(int dec)
        {
            var remainder = dec % Radix; //остаток
            var quotient = dec / Radix; //частное
            var result = remainder.ToString();

            _base.Radix++;

            while (quotient > Radix)
            {

                remainder = quotient % Radix;
                quotient /= Radix;

                result = remainder + result;
                _base.Radix++;
            }

            if (quotient > 0)
            {
                result = quotient + result;
            }

            _base.ResetRadix();
            return result;

        }



    }
}
