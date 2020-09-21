using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Delta_CODE
{
    class Elias_Delta
    {

        public int Decode(string code)
        {
            var zerosCount = 0;
            foreach (var item in code)
            {
                if (item == '0')
                {
                    zerosCount++;
                    continue;
                }
                break;
            }
            var bits = code.Substring(zerosCount + 1, zerosCount);
            var l = (int)Math.Pow(2, zerosCount) + Binary2Int(bits);
            code = code.Substring(2 * zerosCount + 1, l - 1);
            return (int)Math.Pow(2, l - 1) + Binary2Int(code);
            
        }


        public string Encode(int number)
        {
            if (number == 0)
            {
                return "Кода для 0 не существует";
            }
            var binary = Int2Binary(number);
            var binaryLength = binary.Length;
            var code = GammaCode(binaryLength);
            code += binary.Substring(1);
            return code;
        }

        public string GammaCode(int number)
        {
            if (number == 0)
            {
                return "Кода для 0 не существует";
            }
            var code = Int2Binary(number);
            var codeLength = code.Length;
            for (int i = 0; i < codeLength - 1; i++)
            {
                code = "0" + code;
            }
            return code;
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
