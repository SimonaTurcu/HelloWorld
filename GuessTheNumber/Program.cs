using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            int randomNumber = GenerateNumber(1, 100);
            int counter = 1;
            Console.WriteLine("Guess what number I am thinking about");
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("You guessed my number!");
                    return;
                }
                else if (input < randomNumber)
                {
                    Console.WriteLine("Your number is smaller than mine.Try again!");
                    ++counter;
                    continue;
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("Your number is greater than mine.Try again!");
                    ++counter;
                    continue;
                }

            }
        }


        static int GenerateNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
