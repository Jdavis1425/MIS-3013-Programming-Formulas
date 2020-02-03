using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //commandds an input from the user
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;
            //declare our constant variables
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;
            //conditional statement to see what the value of a flip would be
            if(usersGuessAsString == "Heads")
            {
                usersGuess = HEADS_VALUE;
            }
            else
            {
                usersGuess = TAILS_VALUE;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later");
                Console.ReadKey();
                return;
            }
            //generates a random number from the flip
            Random rand = new Random();
            
            //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1
            int randomNumber = rand.Next(0, 2);
            //conditional statement to to show result of flip and whether guess is correct
            if (usersGuess == randomNumber)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }

            Console.ReadKey(); //Prevent the application from closing until we press a key

        }
    }
}
