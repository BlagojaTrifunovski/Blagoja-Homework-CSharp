using System;

namespace AverageNumber
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

            Console.WriteLine("Please insert the third number");
            string userInput3 = Console.ReadLine();
            bool isSuccess3 = int.TryParse(userInput3, out int number3);

            Console.WriteLine("Please insert the fourth number");
            string userInput4 = Console.ReadLine();
            bool isSuccess4 = int.TryParse(userInput4, out int number4);

            if(isSuccess1 && isSuccess2 && isSuccess3 && isSuccess4)
            {
                int result = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine($"The average of {number1},{number2},{number3} and {number4} is:{result}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You insert invalid number");
            }

        }
    }
}
