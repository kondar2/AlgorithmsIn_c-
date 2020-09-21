using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unarn_Code
{
    class Test
    {
        
        public static void TestUnar()
        {
            string number = "10";
            string result = Unar_Dec.Dec_Unar(number);
            string expectedRes = new string('1', Convert.ToInt32(number)) + '0';
            Check(result, expectedRes);

            number = "32";
            result = Unar_Dec.Dec_Unar(number);
            expectedRes = new string('1', Convert.ToInt32(number)) + '0';
            Check(result, expectedRes);


            number = "100000000";
            result = Unar_Dec.Dec_Unar(number);
            expectedRes = new string('1', Convert.ToInt32(number)) + '0';
            Check(result, expectedRes);

            /*---------------------------------------------------------*/

            number = new string('1', 10) + '0';
            int result1 = Unar_Dec.Unar_Decimal(number);
            int expectedRes1 = 10;
            Check1(result1, expectedRes1);

            number = new string('1', 32) + '0';
            result1 = Unar_Dec.Unar_Decimal(number);
            expectedRes1 = 32;
            Check1(result1, expectedRes1);

            number = new string('1', 100000000) + '0';
            result1 = Unar_Dec.Unar_Decimal(number);
            expectedRes1 = 100000000;
            Check1(result1, expectedRes1);

            Console.WriteLine("Тесты пройдены успешно! ");
        }

        public static void Check(string result, string expectedRes)
        {
            if (result != expectedRes)
            {
                Console.Write("Неудачный тест! ");
            }
        }

        public static void Check1(int result, int expectedRes)
        {
            if (result != expectedRes)
            {
                Console.Write("Неудачный тест! ");
            }
        }
    }
}
