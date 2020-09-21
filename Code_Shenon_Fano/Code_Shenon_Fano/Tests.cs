using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Shenon_Fano
{
    class Tests
    {
        public static void TestShenonFano()
        {

            Console.OutputEncoding = Encoding.UTF8;
            var shenon = new Shenon_Fano();

            var input = "Привет, как дела?";
            var expectedRes = new List<string>()
            {
                "01111",
                "10000",
                "10010",
                "10100",
                "0000",
                "10110",
                "11000",
                "0001",
                "0011",
                "0101",
                "0011",
                "0001",
                "11010",
                "0000",
                "11100",
                "0101",
                "11110"
            };
            var result = shenon.GetShenon_Fano(input);
            for (int i = 0; i < result.Count; i++)
            {
                if (result.Count != expectedRes.Count || !result.Contains(expectedRes[i]))
                {
                    Console.WriteLine("Тест для " + input + " неудачный");
                }
                break;
            }

            
            var input1 = "";
            var expectedRes1 = new List<string>(){};
            var result1 = shenon.GetShenon_Fano(input1);
            for (int i = 0; i < result1.Count; i++)
            {
                if (result1.Count != expectedRes1.Count || !result1.Contains(expectedRes1[i]))
                {
                    Console.WriteLine("Тест для " + input1 + " неудачный");
                }
                break;
            }
            

            var input2 = "zxccxz";
            var expectedRes2 = new List<string>()
            {
                "00",
                "01",
                "10",
                "10",
                "01",
                "00"
            };
            var result2 = shenon.GetShenon_Fano(input2);
            for (int i = 0; i < result2.Count; i++)
            {
                if (result2.Count != expectedRes2.Count || !result2.Contains(expectedRes2[i]))
                {
                    Console.WriteLine("Тест для " + input2 + " неудачный");
                }
                break;
            }


            /*
            var input2 = "asdd";
            var expectedRes2 = new List<string>()
            {
                "100",
                "111"
            };
            var result2 = shenon.GetShenon_Fano(input2);
            for (int i = 0; i < result2.Count; i++)
            {
                if (result.Count != expectedRes2.Count || !result.Contains(expectedRes2[i]))
                {
                    Console.WriteLine("Тест для " + input2 + " неудачный");
                }
                break;
            }
            */
        }

    }
}
