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
            /*Define Variables
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
            Console.ReadKey(); */

            double savePerWeek = 0;
            double intRatePerMonth = 0.0;
            int yearsSaved = 0;
            double totalAmountSaved = 0;
            int numYears = 1;
            int numMonths = 1;



            Console.WriteLine("How much money will you save a week?");
            savePerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your interest rate per month? {e.g. 4.5}");
            intRatePerMonth = Convert.ToDouble(Console.ReadLine())/100;

            Console.WriteLine("How many years will you be saving for?");
            yearsSaved = Convert.ToInt32(Console.ReadLine());

            for (int month = 0; month <= yearsSaved*12; month++)
            {
                totalAmountSaved += savePerWeek * 4;
                totalAmountSaved += totalAmountSaved * intRatePerMonth;

                string monthName = month.ToString("N0");

                if (numMonths==1)
                {
                    monthName = "January";
                }
                else if (numMonths== 2)
                {
                    monthName = "February";
                }
                else if (numMonths == 3)
                {
                    monthName = "March";
                }
                else if (numMonths == 4)
                {
                    monthName = "April";
                }
                else if (numMonths == 5)
                {
                    monthName = "May";
                }
                else if (numMonths == 6)
                {
                    monthName = "June";
                }
                else if (numMonths == 7)
                {
                    monthName = "July";
                }
                else if (numMonths == 8)
                {
                    monthName = "August";
                }
                else if (numMonths == 9)
                {
                    monthName = "September";
                }
                else if (numMonths == 10)
                {
                    monthName = "October";
                }
                else if (numMonths == 11)
                {
                    monthName = "November";
                }
                else if (numMonths == 12)
                {
                    monthName = "December";
                }
                Console.WriteLine($"{monthName} @ year {numYears.ToString("n0")} : {totalAmountSaved.ToString("C2")}");

                numMonths++;

                if (month % 12 == 0)
                {
                    numYears++;
                    numMonths = 1;
                }
            }




            Console.ReadKey();
        }
    }
}
