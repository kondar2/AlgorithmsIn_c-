using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenRodeh_Code
{
    class EvenRodeh
    {
        public string Encode(int number)
        {
            var code = "";

            if (number >= 4)
            {
                code = "0";
            }
            else
            {
                code = Int2Binary(number) + code;
                while (code.Length != 3)
                {
                    code = "0" + code;
                }
                return code;
            }

            while (true)
            {
                if (number < 8)
                {
                    code = Int2Binary(number) + code;
                    return code;
                }

                var bitsToPrepend = Int2Binary(number);
                code = bitsToPrepend + code;
                number = bitsToPrepend.Length;

                
            }
            
        }

        public int Decode(string code)
        {
            var codeLength = code.Length;
            var bits = code.Substring(0, 3);
            var number = Binary2Int(bits);
            if (bits[0] == '0')
            {
                return number;
            }

            for (int i = 3; i < code.Length; i++)
            {
                if (code[i] == '0')
                {
                    return number;
                }
                else
                {
                    var substring = code.Substring(i, number);
                    number = Binary2Int(substring);
                    i += substring.Length - 1;
                }
            }
            return number;
        }

        

        public string Int2Binary(int number)
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

        public int Binary2Int(string binary)
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
    }
}
