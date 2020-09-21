using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levinshtein
{
    class Levenshtein
    {

        public int Decode(string code)
        {
            var countOfOnes = 0;
            foreach (var item in code)
            {
                if (item != '0')
                {
                    countOfOnes++;
                    continue;
                }
                break;
            }

            if (countOfOnes == 0)
            {
                return 0;
            }

            code = code.Substring(countOfOnes + 1);
            var digitsToTake = 1;
            var digits = "";
            for (int i = 0; i < countOfOnes - 1; i++)
            {
                digits = "1" + code.Substring(0, digitsToTake);
                code = code.Substring(digitsToTake);
                digitsToTake = Binary2Int(digits);
            }
            return digitsToTake;

        }

        
        public string Encode(int number)
        {
            var res = "";

            var numberOfIterations = GetNumberOfIterations(number);
            for (int i = 0; i < numberOfIterations; i++)
            {
                res += "1";
            }

            res += "0";

            var numList = new List<int>();
            while (number > 0)
            {
                numList.Add(number);
                number = Int2Binary(number).Substring(1).Length;
            }

            var strList = new List<string>();
            if (numList != null)
            {
                foreach (var item in numList)
                {
                    strList.Add(Int2Binary(item).Substring(1));
                }
            }

            strList.Reverse();
            foreach (var item in strList)
            {
                res += item;
            }
            return res;
        }


        private int GetNumberOfIterations(int number)
        {
            return GetNumberOfIterations1(number, 0);
        }

        private int GetNumberOfIterations1(int number, int counter)
        {
            if (number == 0)
            {
                return counter;
            }
            counter++;

            return GetNumberOfIterations1(Int2Binary(number).Substring(1).Length, counter);  //log2
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
