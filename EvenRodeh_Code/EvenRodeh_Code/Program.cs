using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenRodeh_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var encoder = new EvenRodeh();
            Tests.TestEvenRodeh();

            Console.WriteLine("1. Число -> Ивен-Родэ");
            Console.WriteLine("2. Ивен-Родэ -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число:");
                var input = 1000000;
                var code = encoder.Encode(Convert.ToInt32(input));
                Console.WriteLine("\nКод : " + code);
            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите код Ивен-Родэ:");
                var input = Console.ReadLine();
                var decoded = encoder.Decode(input);

                Console.WriteLine("Декодироване: " + decoded);
            }
            Console.ReadKey();


        }
    }
}
