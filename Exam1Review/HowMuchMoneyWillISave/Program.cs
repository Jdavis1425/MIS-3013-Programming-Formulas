//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchMoneyWillISave
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            double userInterestRate = 0;
            double moneySavedPerWeek = 0;
            int yearsSaved = 0;
            double totalAmountSaved = 0; //This is an accumulating variable that we will use to keep track of the total amount saved
            int numYears = 1; //Keeping track of which year we are currently in
            int numMonths = 1; //Keeping track of which month of the year we are in

            //Get User Input
            Console.WriteLine("How much money will you save each week?");
            moneySavedPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your interest rate? {e.g. 4.5} If no interest rate, put 0");
            userInterestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("How many years will you save for?");
            yearsSaved = Convert.ToInt32(Console.ReadLine());


            //Process-Calculate the amount saved after every month
            //Could add loop to add each week
            for (int  month =1;  month <= yearsSaved*12;  month++)
            {
                totalAmountSaved += moneySavedPerWeek * 4;
                totalAmountSaved += totalAmountSaved * userInterestRate;

                string monthName = month.ToString("N0");

                if (numMonths == 1)
                {
                    monthName = "January";
                }
                else if (numMonths == 2)
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
                else 
                {
                    monthName = "December";
                }

                Console.WriteLine($"{monthName} @ year {numYears.ToString("n0")} : {totalAmountSaved.ToString("C2")}");

                numMonths++;

                //adds 1 to the year output 
                if (month % 12 == 0)
                {
                    numYears++;
                    numMonths = 1; //After ran through to 12 (% 12 means divisible by 12) reset numMonths to 1
                }
                

                
            }
            //only complete what the question asks. This is done anything more is just extra

            //Output - e.g. January, year 1: Money saved so far is $380.83
            Console.WriteLine($"Press any key to continue");
            Console.ReadKey();
        } 
    }
}
