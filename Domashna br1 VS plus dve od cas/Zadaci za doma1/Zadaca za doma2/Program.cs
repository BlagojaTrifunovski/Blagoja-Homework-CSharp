using System;

namespace Zadaca_za_doma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number 1,2 or 3");
            string userInput = Console.ReadLine();
            bool isValid = int.TryParse(userInput, out int number);

            if(number == 1 & isValid)
            {
                Console.WriteLine("You got a new car!");
                Console.ReadLine();
            }
            else if(number == 2 && isValid)
            {
                Console.WriteLine("You got a new plane!");
                Console.ReadLine();
            }
            else if(number == 3 && isValid)
            {
                Console.WriteLine("You got a new bike!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You insert a wrong input");
                Console.ReadLine();
            }
        }
    }
}
