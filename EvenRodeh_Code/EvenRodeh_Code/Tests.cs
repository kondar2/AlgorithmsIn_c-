using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenRodeh_Code
{
    class Tests
    {

        static EvenRodeh encoder = new EvenRodeh();
        public static void TestEvenRodeh()
        {

            var expectedRes = new Dictionary<string, string>()
            {
                {"0","000"},
                {"1","001"},
                {"2","010"},
                {"3","011"},
                {"4","1000"},
                {"5","1010"},
                {"6","1100"},
                {"7","1110"},
                {"8","10010000"},
                {"9","10010010"},
                {"10","10010100"},
                {"11","10010110"},
                {"12","10011000"},
                {"13","10011010"},
                {"14","10011100"},
                {"15","10011110"},
                {"16","101100000"},
                {"17","101100010"},
                {"32","1101000000"},
                {"100","11111001000"},
                {"512","100101010000000000"},
                {"1023","100101011111111110"},
                {"1024","1001011100000000000"},
                {"2000","1001011111110100000"},
                {"2500","10011001001110001000"},
           };

            foreach (var item in expectedRes)
            {
                Check(Convert.ToInt32(item.Key), item.Value);
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
