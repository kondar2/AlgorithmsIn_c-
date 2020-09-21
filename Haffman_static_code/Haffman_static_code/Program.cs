using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haffman_static_code
{
    class Program
    {
        static void Main(string[] args)
        {

            Test.TestHuffman();
            Console.WriteLine("Тесты пройдены успешно \n");

            Console.WriteLine("Введите строку для кодирования : ");
            var input = Console.ReadLine();

            var encoder = new HuffmanCode();
            var code = encoder.GetHuffmanCode(input);
            encoder.PrintCodeTable();

            if (input == "")
            {
                code = null;
            }
            else
            {
                Console.WriteLine("\nКод : ");
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(code[i]);
                }
                
            }
            

            Console.ReadKey();
        }
    }
}
