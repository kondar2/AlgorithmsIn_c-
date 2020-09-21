using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Code_Shenon_Fano
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.TestShenonFano();
            //var encoder = new Shenon_Fano();
            // Console.WriteLine(encoder.FractionToBinary(0.125));
            //Console.WriteLine(encoder.Encode(10,"1010"));

            Console.OutputEncoding = Encoding.UTF8;

            
            
            
            var encoder = new Shenon_Fano();

            Console.WriteLine("Введите строку :");
            var input = Console.ReadLine();
            
            var code = encoder.GetShenon_Fano(input);
            

            encoder.PrintTable();

            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(code[i]);
            }
            Console.WriteLine();
            

            

            Console.ReadKey();
        }
    }
}
