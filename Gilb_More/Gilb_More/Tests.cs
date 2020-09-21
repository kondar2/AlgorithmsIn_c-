using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gilb_More
{
    class Tests
    {
        public static void TestGilbert_More()
        {
            var encoder = new Gilb_Moore();

            var input = "Привет, как дела?";
            var expectedRes = new Dictionary<char, string>()
            {
                {'П', "000001"},
                {'р', "000101" },
                {'и', "001001" },
                {'в', "001101" },
                {'е', "01001" },
                {'т', "011000" },
                {',', "011100" },
                {' ', "10000" },
                {'к', "10100" },
                {'а', "11000" },
                {'д', "110110" },
                {'л', "111010" },
                {'?', "111110" }
            };
            encoder.GilbertMooreCode(input);
            var result = encoder.nodeList;
            Check(result, expectedRes, input);


            var input1 = "";
            var expectedRes1 = new Dictionary<char,string>() { };
            encoder.GilbertMooreCode(input1);
            var result1 = encoder.nodeList;
            Check(result1, expectedRes1, input1);


            var input2 = "zxccxz";
            var expectedRes2 = new Dictionary<char, string>()
            {
                {'z', "001"},
                {'x', "100" },
                {'c', "110" }
            };
            encoder.GilbertMooreCode(input2);
            var result2 = encoder.nodeList;
            Check(result2, expectedRes2, input2);


        }

        private static void Check(List<Element> result, Dictionary<char, string> expectedRes, string input)
        {
            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    result.Find(el => expectedRes.Keys.Contains(el.symbol) && expectedRes[el.symbol] == el.code);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Тест для " + input + " неудачный");

                    break;
                }
            }
        }

    }
}
