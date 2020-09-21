using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamma_Livenshtein
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var encoder = new GammaCodLev();
            Tests.TestGammaLevenshtein();

            Console.WriteLine("1. Число -> Гамма Код Левенштейна");
            Console.WriteLine("2. Гамма Код Левенштейна -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число:");
                var input = Console.ReadLine();
                var code = encoder.Encode(Convert.ToInt32(input));
                Console.WriteLine("\nКод : " + code);
            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите гамма код Ливенштейна:");
                var input = Console.ReadLine();
                var decoded = encoder.Decode(input);

                Console.WriteLine("Декодироване: " + decoded);
            }
            Console.ReadKey();

        }
    }
}
