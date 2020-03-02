/*Jatin Davis
 * Prompt the user to input their lucky number.
 * Upon getting the users input, validate that the input is a valid number using Int32.TryParse
 * If the input is not a valid number, output a message to the user stating that you are sorry but you are unable to run the FizzBuzz process due to the input not being a valid number.
 * If the input is divisible by 3, then output {number} Fizz.  If the input is divisible by 5, then output {number} Buzz.  If the input is divisible by 3 AND 5, output {number} FizzBuzz.
 * If it is not divisible by either 3 or 5, simply just output the number.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_FizzBuzz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string userInput;
            int luckyNumber;
            bool isValidNumber;
            //user input

            //checks input until condition is met (in this case isValidNumber being False)
            do
            {
                Console.WriteLine("Enter your lucky number..");
                userInput = Console.ReadLine();
                isValidNumber = Int32.TryParse(userInput, out luckyNumber);

                if (!isValidNumber)
                {
                    Console.WriteLine("Please enter a valid number and try again");
                }
            } while (!isValidNumber);

            //process -
            if (luckyNumber % 15 == 0)
            {
                Console.WriteLine($"{luckyNumber} FizzBuzz");
            }
            else if (luckyNumber % 5 == 0)
            {
                Console.WriteLine($"{luckyNumber} Buzz");
            }
            else if (luckyNumber % 3 == 0)
            {
                Console.WriteLine($"{luckyNumber} Fizz");
            }
            else Console.WriteLine(luckyNumber);
             

            //output - 


            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
