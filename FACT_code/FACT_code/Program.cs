using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACT_code
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Dec -> Fac");
            Console.WriteLine("2. Fac -> Dec\n");
            Console.WriteLine("enter 1 or 2");
            var option = Console.ReadLine();
            var convertDEC_FAC = new ConvertDEC_FAC();
            if (option == "1")
            {
                Console.WriteLine("\n Enter decimal number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                var result = convertDEC_FAC.Dec2Fact(input);
                Console.WriteLine("In fac base: " + result);

            }
            else if (option == "2")
            {
                Console.WriteLine("\nEnter a fatorial base number: ");
                var input = Console.ReadLine();

                var result = convertDEC_FAC.Fac2Dec(input);
                Console.WriteLine("Dec base: " + result);
            }

            Console.ReadKey();

        }
    }
}
