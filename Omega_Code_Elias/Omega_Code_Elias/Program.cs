using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Omega_Code_Elias
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Test.TestEliasOmega();


            
            Console.WriteLine("1. Число -> OmegCodElias");
            Console.WriteLine("2. OmegCodElias -> Число");
            Console.Write("Выберете : ");
            var option1 = Console.ReadLine();
            if (option1 == "1")
            {
                Console.WriteLine("Введите положительное число:");
                var input = "12345678";
                //var input = Console.ReadLine();
                if (input.Length == 0)
                {
                    return;
                }

                var encoder = new EliasOmega();
                var code = encoder.Encode(Convert.ToInt32(input));
                Console.WriteLine("Код: " + code);
                

            }
            else if (option1 == "2")
            {
                Console.WriteLine("Введите OmegCodElias:");
                var input = Console.ReadLine();
                if (input.Length == 0)
                {
                    return;
                }

                var encoder = new EliasOmega();
                var decoded = encoder.Decode(input);
                Console.WriteLine("Декодирование: " + decoded); 

            }
            


            Console.ReadKey();


        }
    }
}
