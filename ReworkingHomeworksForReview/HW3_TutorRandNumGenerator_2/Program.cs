/* Jatin Davis
 * generate 2 random integers each between 1 and 50
 * display the numbers
 * if user answer is correct, congratulate them.
 * if user answer wrong, tell them sorry try again
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_TutorRandNumGenerator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            double userAnswer;

            Random randNum = new Random();
            int n1 = randNum.Next(1, 51);
            int n2 = randNum.Next(1, 51);

            int result = n1 + n2;
            //user input
            //process
            do
            {
                Console.WriteLine($"{n1} + {n2} = ?");
                userAnswer = Convert.ToDouble(Console.ReadLine());

                if (userAnswer!=result)
                {
                    Console.WriteLine("Sorry, your answer is incorrect. Please try again");
                }
            } while (userAnswer!=result);

            //output
            Console.WriteLine($"Congratulations, {result} is the correct answer!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
