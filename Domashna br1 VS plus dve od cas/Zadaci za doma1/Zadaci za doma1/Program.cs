using System;

namespace Zadaci_za_doma1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the first number");
            string userInput1 = Console.ReadLine();
            int num1;
            bool isSuccess1 = int.TryParse(userInput1, out  num1);

            Console.WriteLine("Please insert the second number");
            string userInput2 = Console.ReadLine();
            int num2;
            bool isSuccess2 = int.TryParse(userInput2, out  num2);

            if(isSuccess1 && isSuccess2)
            {

                if(num1 > num2 && num1 % 2 == 0)
                {
                    Console.WriteLine($"The bigger number is {num1} and it's even");
                    Console.ReadLine();
                }
                else if(num1 > num2 && num1 % 2 != 0)
                {
                    Console.WriteLine($"The bigger number is {num1} and it's odd");
                    Console.ReadLine();
                }
                else if(num2 > num1 && num2 % 2 == 0)
                {
                    Console.WriteLine($"The bigger number is {num2} and it's even");
                    Console.ReadLine();
                }
                else if(num2 > num1 && num2 % 2 != 0)
                {
                    Console.WriteLine($"The bigger number is {num2} and it's odd");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You insert invalid value");
                    Console.ReadLine();
                }
            }

        }
    }
}
