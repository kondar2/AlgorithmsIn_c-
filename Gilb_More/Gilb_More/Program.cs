using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gilb_More
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.TestGilbert_More();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите строку :");
            var input = Console.ReadLine();

            var encoder = new Gilb_Moore();
            var code = encoder.GilbertMooreCode(input);

            encoder.PrintTable();

            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(code[i]);
            }

            Console.ReadKey();
        }
    }
}
