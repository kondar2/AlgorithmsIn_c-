using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gilb_More
{
    class Gilb_Moore
    {
        public List<Element> nodeList = new List<Element>();
        private Dictionary<char, int> symbolCount;   // словарь символов с их повторениями

        public List<string> GilbertMooreCode(string input)
        {
            if (input.Length == 0)
            {
                return new List<string>();
            }

            symbolCount = input.GroupBy(symbol => symbol)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var item in symbolCount)
            {
                nodeList.Add(new Element(item.Key, Convert.ToDouble(item.Value) / input.Count()));
            }

            nodeList[0].qumulativeFrequency = 0;
            nodeList[0].sigma = nodeList[0].frequency / 2;
            nodeList[0].length = 1 + Math.Ceiling(-Math.Log(nodeList[0].frequency, 2.0));
            nodeList[0].sigmaBinary = FractionToBinary(nodeList[0].sigma);
            nodeList[0].code = Encode(nodeList[0].length, nodeList[0].sigmaBinary);
            for (var i = 1; i < nodeList.Count; i++)
            {
                nodeList[i].qumulativeFrequency = nodeList[i - 1].qumulativeFrequency + nodeList[i - 1].frequency;
                nodeList[i].sigma = nodeList[i].qumulativeFrequency + nodeList[i].frequency / 2;
                nodeList[i].length = 1 + Math.Ceiling(-Math.Log(nodeList[i].frequency, 2.0));
                nodeList[i].sigmaBinary = FractionToBinary(nodeList[i].sigma);
                nodeList[i].code = Encode(nodeList[i].length, nodeList[i].sigmaBinary);
            }

            var code = new List<string>();
            foreach (var symbol in input)
            {
                code.Add(nodeList.Find(el => el.symbol == symbol).code);
            }

            return code;
        }

        public void PrintTable()
        {
            Console.WriteLine("\n[символ, код]");
            foreach (var item in nodeList)
            {
                Console.WriteLine(item.symbol + "  " + item.code);
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
                var addedZerosCount = Convert.ToInt32(length) - binaryFraction.Length;
                for (int j = 0; j < addedZerosCount; j++)
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
