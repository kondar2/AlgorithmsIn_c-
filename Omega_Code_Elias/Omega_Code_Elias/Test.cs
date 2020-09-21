using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Omega_Code_Elias
{
    class Test
    {
        static EliasOmega encoder = new EliasOmega();
        public static void TestEliasOmega()
        {

            var expectedRes = new Dictionary<string, string>()
            {
                {"1",  "0" },
                {"2", "100" },
                {"3", "110" },
                {"4", "101000" },
                {"5", "101010" },
                {"6", "101100" },
                {"7", "101110" },
                {"8", "1110000" },
                {"9", "1110010" },
                {"10","1110100" },
                {"11","1110110" },
                {"12", "1111000" },
                {"13", "1111010" },
                {"14", "1111100" },
                {"15", "1111110" },
                {"16", "10100100000" },
                {"17",  "10100100010" },
                {"32", "101011000000" },
                {"100", "1011011001000"},
                {"127", "1011011111110"},
            };

            foreach (var item in expectedRes)
            {
                Check(Convert.ToInt32(item.Key), item.Value);
            }

            Console.WriteLine("Тестирование пройдено успешно !");
        }

        private static void Check(int input, string expectedRes)
        {
            var code = encoder.Encode(input);
            var decoded = encoder.Decode(code);
            if (code != expectedRes || input != decoded)
            {
                Console.WriteLine("Тест для " + input + "Удачный " + expectedRes);
            }
        }








    }
}
