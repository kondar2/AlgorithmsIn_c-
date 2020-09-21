using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levinshtein
{
    class Tests
    {
        static Levenshtein encoder = new Levenshtein();

        public static void TestLevenshtein()
        {
            var expectedRes = new List<string>()
            {   "0",
                "10",
                "1100",
                "1101",
                "1110000",
                "1110001",
                "1110010",
                "1110011",
                "11101000",
                "11101001",
                "11101010",
                "11101011",
                "11101100",
                "11101101",
                "11101110",
                "11101111",
                "111100000000",
                "111100000001",
                "111100000010",
                "111100000011",
                "111100000100",
                "111100000101",
                "111100000110",
                "111100000111",
                "111100001000"
            };


            for (int input = 0; input < 25; input++)
            {
                Check(input, expectedRes[input]);
            }

            
            
                Console.WriteLine("Тесты прошли успешно! ");
            
        }
        

        private static void Check(int input, string expectedRes)
        {
            var code = encoder.Encode(input);
            var decoded = encoder.Decode(code);
            if (code != expectedRes || input != decoded)
            {
                Console.WriteLine("Ошибка в тесте :" + input + expectedRes);
            }
            
        }
    }
    
}
