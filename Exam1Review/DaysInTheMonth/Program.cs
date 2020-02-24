using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //define the variable we are adjusting throughout
            string monthName = "";

            //get user input, store in variable
            Console.WriteLine("Enter the month you would like: {i.e. January, February, etc..");
            monthName = Console.ReadLine();

            //Process- Determine how many days are in the users month
            if (monthName == "January")
            {
                Console.WriteLine("There are 31 days in January");
            }
            else if (monthName == "February")
            {

                Console.WriteLine("Is it a Leap year? {Yes or No}");
                string leapYear = Console.ReadLine();

                if (leapYear == "Yes")
                {
                    Console.WriteLine("There are 29 days in February with a Leap Year");
                }

                else
                {
                    Console.WriteLine("There are 28 days in February without a Leap Year");
                }


            }
            else if (monthName == "March")
            {
                Console.WriteLine("There are 31 days in March");
            }
            else if (monthName == "April")
            {
                Console.WriteLine("There are 30 days in April");
            }
            else if (monthName == "May") 
            {
                Console.WriteLine("There are 30 days in May");
            }
            else if (monthName == "June")
            {
                Console.WriteLine("There are 30 days in June");
            }
            else if (monthName == "July")
            {
                Console.WriteLine("There are 31 days in July");
            }
            else if (monthName == "August")
            {
                Console.WriteLine("There are 31 days in August");
            }
            else if (monthName == "September")
            {
                Console.WriteLine("There are 30 days in September");
            }
            else if (monthName == "October")
            {
                Console.WriteLine("There are 31 days in October");
            }
            else if (monthName == "November")
            {
                Console.WriteLine("There are 30 days in November");
            }
            else if (monthName == "December")
            {
                Console.WriteLine("There are 31 days in December");
            }
            Console.ReadKey();
            }

        }
    } //if (monthName== "January" || monthName == "months with 31 days)
      //monthDays=31; Same for 30 day months
      //Console.WriteLine($"There are {monthDays.ToString("N0")} in {monthName}")

