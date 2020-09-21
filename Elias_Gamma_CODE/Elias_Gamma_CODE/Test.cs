using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Gamma_CODE
{
    class Test
    {
        static Elias_Gamma encoder = new Elias_Gamma();
        public static void TestEliasGamma()
        {

            var expectedRes = new Dictionary<string, string>()
            {
                {"1","1"},
                {"2","010"},
                {"3","011"},
                {"4","00100"},
                {"5","00101"},
                {"6","00110"},
                {"7","00111"},
                {"8","0001000"},
                {"9","0001001"},
                {"10","0001010"},
                {"11","0001011"},
                {"12","0001100"},
                {"13","0001101"},
                {"14","0001110"},
                {"15","0001111"},
                {"16","000010000"},
                {"17","000010001"},
                {"18","000010010"},
                {"100","0000001100100"},
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
                Console.WriteLine("Тест для " + input + " Удачный");
            }
        }
    }
}
