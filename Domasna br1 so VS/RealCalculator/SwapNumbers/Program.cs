using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the first number");
            string userInput1 = Console.ReadLine();
            bool isSuccess1 = int.TryParse(userInput1, out int number1);

            Console.WriteLine("Please insert the second number");
            string userInput2 = Console.ReadLine();
            bool isSuccess2 = int.TryParse(userInput2, out int number2);

            if(isSuccess1 && isSuccess2)
            {
                int swappingNumber1 = number2;
                int swappingNumber2 = number1;
                Console.WriteLine($"The first number was {number1} and after swapping is {swappingNumber1} ");
                Console.WriteLine($"The second number was {number2} and after swapping is {swappingNumber2}");
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
