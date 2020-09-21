using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Delta_CODE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var encoder = new Elias_Delta();

            Test.TestEliasDelta();


            
            Console.WriteLine("Введите положительное число для кодирования: ");
            var input = Console.ReadLine();
            var Value = "";

            for (int i = 0; i < input.Length; i++)
            {
                Value += Convert.ToInt32(input[i]);
            }


            var code = encoder.Encode(Convert.ToInt32(Value));
            var decoded = encoder.Decode(code);

            Console.WriteLine("Кодирование : " + code);
            Console.WriteLine("Декодирование : " + Convert.ToChar(decoded));


            /*
            var code = encoder.Encode(Convert.ToInt32(input));
            var decoded = encoder.Decode(code);

            Console.WriteLine("Кодирование : " + code);
            Console.WriteLine("Декодирование : " + decoded);
            */


            Console.ReadKey();

        }
    }
}
