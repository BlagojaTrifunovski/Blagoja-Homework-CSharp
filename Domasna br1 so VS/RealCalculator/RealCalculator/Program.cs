using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Please insert the first number");
            string userInput1 = Console.ReadLine();
            bool isSuccess1 = int.TryParse(userInput1, out int number1);

             Console.WriteLine("Please insert the second number");
            string userInput2 = Console.ReadLine();
            bool isSuccess2 = int.TryParse(userInput2, out int number2);

            Console.WriteLine($"Choose operation +,-,* or /");
            string userInputOperation = Console.ReadLine();

            if( isSuccess1 && isSuccess2 && userInputOperation =="+")
            {
                int result1 = number1 + number2;
                Console.WriteLine(result1);
                Console.ReadLine();
            }
                else if(isSuccess1 && isSuccess2 && userInputOperation == "-")
            {
                int result2 = number1 - number2;
                Console.WriteLine(result2);
                Console.ReadLine();
            }           
            else if(isSuccess1 && isSuccess2 && userInputOperation == "*")
            {
                int result3 = number1 * number2;
                Console.WriteLine(result3);
                Console.ReadLine();
            }
            else if(isSuccess1 && isSuccess2 && userInputOperation == "/")
            {
                int result4 = number1 / number2;
                Console.WriteLine(result4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You insert invalid number");
                Console.ReadLine();
            }
        }
    }
}
