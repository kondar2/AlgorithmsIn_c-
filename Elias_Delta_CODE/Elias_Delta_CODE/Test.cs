using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Delta_CODE
{
    class Test
    {

        static Elias_Delta encoder = new Elias_Delta();
        public static void TestEliasDelta()
        {

            var expectedRes = new Dictionary<string, string>()
            {
                {"1","1"},
                {"2","0100"},
                {"3","0101"},
                {"4","01100"},
                {"5","01101"},
                {"6","01110"},
                {"7","01111"},
                {"8","00100000"},
                {"9","00100001"},
                {"10","00100010"},
                {"11","00100011"},
                {"12","00100100"},
                {"13","00100101"},
                {"14","00100110"},
                {"15","00100111"},
                {"16","001010000"},
                {"17","001010001"},
           };

            foreach (var item in expectedRes)
            {
                Check(Convert.ToInt32(item.Key), item.Value);
            }

            Console.WriteLine("Тестирование прошло успешно!");
        }

        private static void Check(int input, string expectedRes)
        {
            var code = encoder.Encode(input);
            var decoded = encoder.Decode(code);
            if (code != expectedRes || input != decoded)
            {
                Console.WriteLine("Тест для " + input + " Успешный ");
            }
        }

    }
}
