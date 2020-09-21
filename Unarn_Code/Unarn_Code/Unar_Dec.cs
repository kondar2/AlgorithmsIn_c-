using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unarn_Code
{
    class Unar_Dec
    {
        public static int Unar_Decimal(string number)
        {
            var symbolCount = number.GroupBy(symbol => symbol).ToDictionary(g => g.Key, g => g.Count());

            int CountOne = 0;

            foreach (KeyValuePair<char, int> item in symbolCount)
            {
                if (item.Key == '1')
                {
                    CountOne = item.Value;

                }
            }
            return CountOne;
        }

            

        public static string Dec_Unar(string number)
        {
            string ansver = new string('1', Convert.ToInt32(number)) + '0';

            return ansver;
        }

        
    }
}
