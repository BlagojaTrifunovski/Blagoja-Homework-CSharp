using System;

namespace Zadaci_za_doma1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[6];
            int i = 0;

            while (i < 6)
            {
                Console.Write($"Enter number: ");
                string userInput = Console.ReadLine();
                bool isOkNum = int.TryParse(userInput, out int num);

                if (isOkNum)
                {
                    numbers[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            int sumEvenNumbers = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEvenNumbers += number;
                }
            }

            Console.WriteLine($"Sum of even numbers: {sumEvenNumbers}");



        }
    }
}
