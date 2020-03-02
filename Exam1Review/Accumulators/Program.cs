//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            int counter;
            int sum = 0; //When going to be adding numbers, start at 0
            double multiplication = 1;//multiplication start at 1

            //Processes - Adding up all numbers from 1 to 100.
            //          - Multiplying all numbers from 1 to 100
            //Defined end so we use FOR loop
            for (counter = 1; counter <= 100; counter++)
            {
                sum += counter;
                multiplication *= counter;
            }
            Console.WriteLine($"The summation of numbers from 1-100 is {sum.ToString("n0")}");
            Console.WriteLine($"The product of multiplying all number from 1-100 is {multiplication.ToString("n0")}");


            //Output - Results from calculations

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
