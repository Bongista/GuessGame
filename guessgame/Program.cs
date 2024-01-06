using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

//GuessingGame by Mbongiseni Ntimane
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int numberOfGuesses = 0;

            Console.WriteLine("Guess the number between 1 and 100:");

            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses++;

                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations, you guessed the number!");
                    Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("The number is Higher than your guess, try again.");
                }
                else
                {
                    Console.WriteLine("The number is Lower than your guess, try again.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            
        }
    }
}
