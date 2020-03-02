/* Jatin Davis
 * you burn 3.9 calories per minute.
 * ask user to input how many calories they wish to burn.
 * output the amount of calories burned after each minute
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_TimeToBurn_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            double calories = 3.9;
            double calGoal = 0;
            int minute = 1;
            double calBurn = 0;

            //user input
            Console.Write("How many calories would you like to burn this workout?");
            calGoal = Convert.ToDouble(Console.ReadLine());

            //processes

            while (calBurn<=calGoal)
            {
                calBurn = calories * minute;
                Console.WriteLine($"After {minute} minutes, you have burned {calBurn} calories");
                minute++;
            }
            
            //output

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
