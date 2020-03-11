//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation would you like to run? Coin Flip or Calculator?");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice=="coin flip")
            {
                
            }
            else
            {

            }
        }
        static void Participation1(string[] participation)
        {
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;
            
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;
            
            if (usersGuessAsString == "Heads")
            {
                usersGuess = HEADS_VALUE;
            }
            else if (usersGuessAsString == "Tails")
            {
                usersGuess = TAILS_VALUE;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later");
                Console.ReadKey();
                return;
            }
            
            Random rand = new Random();

            
            int randomNumber = rand.Next(0, 2);
            
            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {usersGuessAsString}");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {usersGuessAsString}");
                }
            }

            Console.ReadKey();
        }
        static void Participation3(string[] participation)
        {

        }
    }
}
