using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golomb_Code
{
    class Test
    {
        static Golomb encoder = new Golomb();
        public static void TestGolomb()
        {
            var expectedRes = new Dictionary<string, Dictionary<string, string>>()
            {
                {
                    "1", new Dictionary<string, string>()
                        {
                            {"0", "0"},
                            {"1", new string('1', 1) + "0"},
                            {"2", new string('1', 2) + "0"},
                            {"3", new string('1', 3) + "0"},
                            {"4", new string('1', 4) + "0"},
                            {"5", new string('1', 5) + "0"},
                            {"6", new string('1', 6) + "0"},
                            {"7", new string('1', 7) + "0"},
                            {"8", new string('1', 8) + "0"},
                            {"9", new string('1', 9) + "0" },
                            {"10", new string('1', 10) + "0"},
                            {"11", new string('1', 11) + "0"},
                            {"12", new string('1', 12) + "0"},
                            {"13", new string('1', 13) + "0"},
                            {"14", new string('1', 14) + "0"},
                            {"15", new string('1', 15) + "0"},
                            {"16", new string('1', 16) + "0"},
                            {"17", new string('1', 17) + "0"},
                        }
                },
                {
                    "2", new Dictionary<string, string>()
                        {
                            {"0","00"},
                            {"1","01"},
                            {"2","100"},
                            {"3","101"},
                            {"4","1100"},
                            {"5","1101"},
                            {"6","11100"},
                            {"7","11101"},
                            {"8","111100"},
                            {"9","111101"},
                            {"10","1111100"},
                            {"11","1111101"},
                            {"12","11111100"},
                            {"13","11111101"},
                            {"14","111111100"},
                            {"15","111111101"},
                            {"16","1111111100"},
                            {"17","1111111101"},
                        }
                },
                {
                    "3", new Dictionary<string, string>()
                        {
                            {"0","00"},
                            {"1","010"},
                            {"2","011"},
                            {"3","100"},
                            {"4","1010"},
                            {"5","1011"},
                            {"6","1100"},
                            {"7","11010"},
                            {"8","11011"},
                            {"9","11100"},
                            {"10","111010"},
                            {"11","111011"},
                            {"12","111100"},
                            {"13","1111010"},
                            {"14","1111011"},
                            {"15","1111100"},
                            {"16","11111010"},
                            {"17","11111011"},
                        }
                },
                {
                    "8", new Dictionary<string, string>()
                        {
                            {"0","0000"},
                            {"1","0001"},
                            {"2","0010"},
                            {"3","0011"},
                            {"4","0100"},
                            {"5","0101"},
                            {"6","0110"},
                            {"7","0111"},
                            {"8","10000"},
                            {"9","10001"},
                            {"10","10010"},
                            {"11","10011"},
                            {"12","10100"},
                            {"13","10101"},
                            {"14","10110"},
                            {"15","10111"},
                            {"16","110000"},
                            {"17","110001"},
                        }
                },
            };

            foreach (var item in expectedRes)
            {
                Check(Convert.ToInt32(item.Key), item.Value);
            }

            Console.WriteLine("Тесты прошли успешно !");
        }

        private static void Check(int m, Dictionary<string, string> expectedResults)
        {
            foreach (var item in expectedResults)
            {
                var input = Convert.ToInt32(item.Key);
                var expectedRes = item.Value;
                var code = encoder.GolombCodeNoHuffman(input, m);
                var decoded = encoder.DecodeGolombCodeNoHuffman(code, m);
                if (code != expectedRes || input != decoded)
                {
                    Console.WriteLine("Тест для n = " + input + ", m = " + m + " Удачный");
                }
            }
        }


    }
}
