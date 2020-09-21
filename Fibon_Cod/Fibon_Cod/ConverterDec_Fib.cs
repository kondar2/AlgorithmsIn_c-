using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibon_Cod
{
    class ConverterDec_Fib
    {
        private Fibon_Base fibBase;

        private int Radix
        {
            get
            {
                return fibBase.Radix;
            }
            set
            {
                fibBase.Radix = value;
            }
        }

        public ConverterDec_Fib()
        {
            this.fibBase = new Fibon_Base();
        }

        public int Fib2Dec(string fib)
        {
            var n = 1;
            var res = 0;
            for (int i = fib.Length - 1; i >= 0; i--)
            {
                res += Convert.ToInt32(fib[i].ToString()) * fibBase.GetFibMember(n++);
            }
            fibBase.ResetRadix();
            return res;
        }

        private void SetBiggestRadixForNumber(int number)
        {
            fibBase.Radix = fibBase.CalculateBiggestRadixForNumber(number);
        }


        public string Dec2Fib(int dec)
        {
            if (dec == 0)
            {
                return "0";
            }

            SetBiggestRadixForNumber(dec);  //Radix = max приближенное число фиб к dec

            var reminder = dec - Radix;  //25 = 25 - 21 = 4
            

            var position = fibBase.FindMemberPosition(Radix);        //позиция max приближ
            var str = String.Join("0", new String[position + 1]);    // конструирую строку из нулей длинной max Radix
            var result = new StringBuilder(str);
            result.Replace('0','1', result.Length - position, 1);    //ставлю единицу на позицию max Radix

            SetBiggestRadixForNumber(reminder);         //4 = 4 - 3 = 1
            while (reminder >= Radix)
            {
            
                reminder -= Radix;  // 4-3 = 1

                position = fibBase.FindMemberPosition(Radix);  //позицию max Radix
                result.Replace('0', '1', result.Length - position, 1);

                SetBiggestRadixForNumber(reminder);
            }

            fibBase.ResetRadix();
            return result.ToString();

            
        }




    }
}
