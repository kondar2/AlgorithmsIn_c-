using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamma_Livenshtein
{
    class Tests
    {
        static GammaCodLev encoder = new GammaCodLev();
        public static void TestGammaLevenshtein()
        {

            var expectedRes = new Dictionary<string, string>()
            {
                {"1", "1" },
                {"5", "01001" },
                {"13", "0100011" },
                {"20", "000001001" },
                {"63", "01010101011" },
                {"129",  "010000000000001" },
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
