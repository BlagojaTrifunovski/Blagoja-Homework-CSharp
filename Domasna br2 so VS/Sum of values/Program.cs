using System;

namespace Sum_of_values
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number: ");
                string userInput = Console.ReadLine();
                int parsedUserInput = int.Parse(userInput);
                numbers[i] = parsedUserInput;
                 sum += numbers[i];
            }
            Console.WriteLine("SUM IS: " + sum);


        }
    }
}
