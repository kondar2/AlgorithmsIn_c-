using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Omega_Code_Elias
{
    class EliasOmega
    {

        public int Decode(string code)
        {
            var n = 1;
            while (code.Length > 0)
            {
                var bit = code[0];
                code = code.Substring(1);
                if (bit == '1')
                {
                    if (n + 1 > code.Length)
                    {
                        n = code.Length - 1;
                    }
                    var nextBinary = bit + code.Substring(0, n);
                    code = code.Substring(n);
                    var buff = Binary2Int(nextBinary);
                    if (buff == 0)
                    {
                        return n;
                    }
                    n = buff;
                }
            }
            return n;
        }

        

        public string Encode(int number)
        {
            var code = "0";
            Encode(number, ref code);
            return code;
        }

        private void Encode(int number, ref string code)
        {
            if (number == 0)
            {
                code = "Кода для 0 не существует";
                return;
            }

            if (number == 1)
            {
                return;
            }

            var bitsToPrepend = Int2Binary(number);
            code = bitsToPrepend + code;
            number = bitsToPrepend.Length - 1;
            Encode(number, ref code);
        }


        private int Binary2Int(string binary)
        {
            var res = 0;
            var multiplier = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                res += Convert.ToInt32(binary[i].ToString()) * multiplier;
                multiplier *= 2;
            }
            return res;
        }
        private string Int2Binary(int number)
        {
            var res = "";
            if (number == 0)
            {
                return "0";
            }
            while (number != 0)
            {
                res = number % 2 + res;
                number /= 2;
            }
            return res;
        }





    }
}
