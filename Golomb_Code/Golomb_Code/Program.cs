using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golomb_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Test.TestGolomb();


            Console.WriteLine("1. Число -> Код Голомба");
            Console.WriteLine("2. Код Голомба -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число:");
                var input = Console.ReadLine();
                Console.WriteLine("Введите параметр m:");
                var m = Console.ReadLine();
                if (m.Length == 0 || input.Length == 0)
                {
                    return;
                }

                var encoder = new Golomb();
                var code = encoder.GolombCodeNoHuffman(Convert.ToInt32(input), Convert.ToInt32(m));
                Console.WriteLine("Код: " + code);
            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите Код Голомба:");
                var input = Console.ReadLine();
                Console.WriteLine("Введите параметр m:");
                var m = Console.ReadLine();
                if (m.Length == 0 || input.Length == 0)
                {
                    return;
                }

                var encoder = new Golomb();
                
                var decoded = encoder.DecodeGolombCodeNoHuffman(input, Convert.ToInt32(m));
                Console.WriteLine("Декодирование: " + decoded);
            }
            
            Console.ReadKey();
            
        }
    }
}
