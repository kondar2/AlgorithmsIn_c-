using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fibon_Cod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

           
            var converterDec_Fib = new ConverterDec_Fib();
            Console.WriteLine("1. Dec -> Fib");
            Console.WriteLine("2. Fib -> Dec\n");
            Console.Write("Enter option: ");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("\nEnter a dec base :");
                var input = Convert.ToInt32(Console.ReadLine());

                var result = converterDec_Fib.Dec2Fib(input);
                Console.WriteLine("Fib code: " + result);
            }
            else if (option == "2")
            {
                Console.WriteLine("\nEnter a fib base :");
                var input = Console.ReadLine();

                var result = converterDec_Fib.Fib2Dec(input);
                Console.WriteLine("Dec base: " + result);
            }
            

            Console.ReadKey();


        }
    }
}
