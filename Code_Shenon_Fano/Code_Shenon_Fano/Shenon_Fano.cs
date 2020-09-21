using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Shenon_Fano
{
    class Shenon_Fano
    {
        private Dictionary<char, double> symbolFrequencies;  //частоты символов
        private Dictionary<char, double> qumulativeFreq;  //совокупная частота
        private Dictionary<char, double> lengthForSymbols;  //длина для символа
        private Dictionary<char, string> symbolCodes;  //код символа
        private IOrderedEnumerable<KeyValuePair<char, int>> res;
        private string input;

        public List<string> GetShenon_Fano(string input)
        {
            if (input.Length == 0)
            {
                return new List<string>();
            }
            this.input = input;
            symbolFrequencies = new Dictionary<char, double>();
            qumulativeFreq = new Dictionary<char, double>();
            lengthForSymbols = new Dictionary<char, double>();
            symbolCodes = new Dictionary<char, string>();

            PrepareTables();

            var code = new List<string>();
            foreach (var symbol in input)
            {
                code.Add(symbolCodes[symbol]);
            }

            return code;
        }

              

        private void PrepareTables()
        {
            res = input.GroupBy(symbol => symbol).ToDictionary(g => g.Key, g => g.Count()).OrderBy(el => -el.Value);

            foreach (var item in res)
            {
                symbolFrequencies.Add(item.Key, Convert.ToDouble(item.Value) / input.Count());    
                //частота для символа
                lengthForSymbols.Add(item.Key, Math.Ceiling(-Math.Log(symbolFrequencies[item.Key], 2.0)));
                //длина двоичного представления

            }
            qumulativeFreq.Add(res.First().Key, 0);  
            //добовляет первый символ из input и value = 0 тк q1=0; q2=q1+p1;...
            for (int i = 1; i < symbolFrequencies.Count; i++)
            {
                qumulativeFreq.Add(symbolFrequencies.ElementAt(i).Key, qumulativeFreq.ElementAt(i - 1).Value
                    + symbolFrequencies.ElementAt(i - 1).Value);
            }

            
            foreach (var item in res)
            {
                symbolCodes.Add(item.Key, Encode(lengthForSymbols[item.Key],
                    FractionToBinary(qumulativeFreq[item.Key])));
            }
        }
        

        public void PrintTable()
        {
            Console.WriteLine("[символ, код]");
            foreach (var item in res)
            {
                Console.WriteLine(item.Key + "  " + symbolCodes[item.Key]);
            }
        }


        private string Encode(double length, string binaryFraction)
        {
            string res = "";
            if (length <= binaryFraction.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    res += binaryFraction[i];
                }
            }
            else
            {
                for (int i = 0; i < binaryFraction.Length; i++)
                {
                    res += binaryFraction[i];
                }
                var addedZeroCount = Convert.ToInt32(length) - binaryFraction.Length;
                for (int j = 0; j < addedZeroCount; j++)
                {
                    res += 0;
                }
            }

            return res;
        }


        private string FractionToBinary(double fraction)
        {
            int whole;
            string res = "";
            do
            {
                fraction *= 2;
                whole = Convert.ToInt32(fraction.ToString().First().ToString());
                fraction -= whole;
                res += whole;

            } while (fraction != .0);
            return res;
        }







    }
}
