using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Gamma_CODE
{
    class Elias_Gamma
    {
        public string Encode(int number)
        {
            if (number == 0)
            {
                return "Для 0 кода не существует";
            }
            var code = Int2Binary(number);
            var codeLength = code.Length;
            for (int i = 0; i < codeLength - 1; i++)
            {
                code = "0" + code;
            }
            return code;
        }

        public int Decode(string code)
        {
            var zerosCount = 0;
            foreach (var item in code)
            {
                if (item != '1')
                {
                    zerosCount++;
                    continue;
                }
                break;
            }
            var bits = code.Substring(zerosCount + 1);
            return (int)Math.Pow(2, zerosCount) + Binary2Int(bits);
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
