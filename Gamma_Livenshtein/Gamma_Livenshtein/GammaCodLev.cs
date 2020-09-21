using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamma_Livenshtein
{
    class GammaCodLev
    {
        public int Decode(string code)
        {
            if (code.Length == 1)
            {
                return Convert.ToInt32(code);
            }

            var reversedBinary = "";
            for (int i = 1; i < code.Length; i += 2)
            {
                reversedBinary += code[i];
            }
            reversedBinary += code[code.Length - 1];

            var binary = new string(reversedBinary.Reverse().ToArray());

            return Binary2Int(binary);

        }

        public string Encode(int number)
        {
            var binary = Int2Binary(number);
            binary = new string(binary.Reverse().ToArray());
            var res = "";

            for (int i = 0; i < binary.Length - 1; i++)
            {
                res += "0" + binary[i];
            }
            res += binary[binary.Length - 1];
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

    }
}
