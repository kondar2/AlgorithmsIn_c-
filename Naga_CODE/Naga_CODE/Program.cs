using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naga_CODE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Dec to Nega2");
            Console.WriteLine("2. Nega2 to Dec");
            Console.WriteLine("Enter option: ");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Write("Enter a Dec number: ");
                var input = Console.ReadLine();
                var number = Convert.ToInt64(input);

                Console.
                var nega = Nag_Dec.DecToNeg2(number);
                Console.WriteLine("Nega2: " + nega);
            }
            else if (option == "2")
            {
                Console.Write("Enter a Nega2 number: ");
                var nega = Console.ReadLine();
                var res = Nag_Dec.Nag2toDec(nega);
                Console.WriteLine("Dec: " + res);
            }
            
            Console.ReadKey();
        }

       


    }
}
