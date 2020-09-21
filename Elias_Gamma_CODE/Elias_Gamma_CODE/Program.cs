using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elias_Gamma_CODE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            var encoder = new Elias_Gamma();

            Test.TestEliasGamma();

            Console.WriteLine("Введите положительное число для кодирования:");
            var input = Console.ReadLine();

            var code = encoder.Encode(Convert.ToInt32(input));
            var decoded = encoder.Decode(code);

            Console.WriteLine("Кодирование: " + code);
            Console.WriteLine("Декодирование: " + decoded);

            Console.ReadKey();



        }
    }
}
