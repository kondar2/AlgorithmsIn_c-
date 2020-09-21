using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rice_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Test.TestRice();

           
            Console.WriteLine("1. Число -> Rice_code");
            Console.WriteLine("2. Rice_code -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число: ");
                var input = Console.ReadLine();
                Console.WriteLine("Введите параметр k : ");
                var k = Console.ReadLine();
                if (input.Length == 0 || k.Length == 0)
                {
                    return;
                }

                var m = Convert.ToInt32(Math.Pow(2.0, Convert.ToInt32(k)));
                try
                {
                    var encoder = new Rice();
                    var code = encoder.RiceCode(Convert.ToInt32(input), m);
                    
                    Console.WriteLine("Код: " + code);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите код Райса: ");
                var input = Console.ReadLine();
                Console.WriteLine("Введите параметр k : ");
                var k = Console.ReadLine();
                if (input.Length == 0 || k.Length == 0)
                {
                    return;
                }

                var m = Convert.ToInt32(Math.Pow(2.0, Convert.ToInt32(k)));
                try
                {
                    var encoder = new Rice();
                    
                    var decoded = encoder.DecodeRiceCode(input, m);
                    
                    Console.WriteLine("Декодирование: " + decoded);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            

            Console.ReadKey();


        }
    }
}
