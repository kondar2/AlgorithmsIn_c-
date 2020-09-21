using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levinshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var encoder = new Levenshtein();
            Tests.TestLevenshtein();
           
            Console.WriteLine("1. Число -> Код Левенштейна");
            Console.WriteLine("2. Код Левенштейна -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число:");
                var input = 1999999999;
                var code = encoder.Encode(Convert.ToInt32(input));
                Console.WriteLine("\nКод : " + code);
            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите код Ливенштейна:");
                var input = Console.ReadLine();
                var decoded = encoder.Decode(input);

                Console.WriteLine("Декодироване: " + decoded);
            }
            Console.ReadKey();
            
        }
    }
}
