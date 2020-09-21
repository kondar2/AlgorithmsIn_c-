using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unarn_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Test.TestUnar();
            Console.WriteLine("Введите число : \n 1 - Число -> Унарный код \n 2 - Унарный код -> Число \n ");
            var input = Console.ReadLine();

            switch (input.ToString())
            {
                case "1":
                    Console.WriteLine("Введите положительное число : ");
                    var number = Console.ReadLine();
                    Console.WriteLine("Код : " + Unar_Dec.Dec_Unar(number));
                    break;
                case "2":
                    Console.WriteLine("Введите унарный код : ");
                    number = Console.ReadLine();
                    Console.WriteLine("Код : " + Unar_Dec.Unar_Decimal(number));
                    break;
                default:
                    Console.WriteLine("Неверное число");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
