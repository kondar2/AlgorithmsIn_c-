using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haffman_static_code
{
    class Test
    {
        public static void TestHuffman()
        {
            var encoder = new HuffmanCode();

            var s = new string('a', 10) + new string('b', 9) + new string('c', 8) +
                new string('d', 7) + new string('v', 3) + new string('g', 1);
            encoder.GetHuffmanCode(s);
            var symbolMap = encoder.GetSymbolMap();
            var expectedRes = new Dictionary<string, string>()
            {
                {"a","10" },
                {"b","01" },
                {"c","00" },
                {"d","111" },
                {"v","1101" },
                {"g","1100" }

            };
            Check(symbolMap, expectedRes, s);

             s = new string(' ', 5) + new string('i', 4) + new string('2', 3) +
                new string('d', 1);
            encoder.GetHuffmanCode(s);
             symbolMap = encoder.GetSymbolMap();
             expectedRes = new Dictionary<string, string>()
            {
                {" ","0" },
                {"i","10" },
                {"2","111" },
                {"d","110" }

            };
            Check(symbolMap, expectedRes, s);


            s = new string(' ', 1) + new string('i', 2) + new string('2', 3) +
               new string('d', 4) + new string('g', 5) + new string('d', 6) + new string('h', 7) +
               new string('j', 8) + new string('b', 9) + new string('n', 10) + new string('v', 11) + 
               new string('c', 12) + new string('f', 13);
            encoder.GetHuffmanCode(s);
            symbolMap = encoder.GetSymbolMap();
            expectedRes = new Dictionary<string, string>()
            {
                {"f","110" },
                {"c","101" },
                {"v","011" },
                {"d","010" },
                {"n","001" },
                {"b","000" },
                {"j","1111" },
                {"h","1110" },
                {"g","1000" },
                {"2","10011" },
                {"i","100101" },
                {" ","100100" }

            };
            Check(symbolMap, expectedRes, s);




        }

        private static void Check(Dictionary<string,string> symbolMap, Dictionary<string,string> expectedRes, string s)
        {
            foreach (var symbol in expectedRes)
            {
                if (!symbolMap.ContainsKey(symbol.Key) || symbolMap[symbol.Key] != symbol.Value)
                {
                    Console.WriteLine("Неудачный тест! ");
                    return;
                }/*
                else
                {
                    Console.WriteLine("Тесты пройдены успешно \n");
                }*/
            }
        }


    }
}
