/*Jatin Davis
 * Ask the user to input their grade percentage (e.g. the use will enter 98 if they had an overall grade of 98% in their course) for their Accounting, Marketing, Economics and MIS courses.
 * Assume each course is worth 3 credit hours.
 * Once you have all of their grades output what letter grade they earned for each course
 * After you have output all of their letter grades, output their overall GPA for the semester
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_GPA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            double accountingGrade = 0;
            double marketingGrade = 0;
            double economicsGrade = 0;
            double misGrade = 0;
            const double credits = 3.0;
            const int numberOfCourses = 4;


            //user input
            Console.WriteLine("Enter your grade for Accounting..");
            accountingGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade for Marketing..");
            marketingGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade for Economics..");
            economicsGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade for MIS..");
            misGrade = Convert.ToDouble(Console.ReadLine());

            //process - output letter grade for each course. assume each course is 3 credit hours

            string accountingLetterGrade;
            string marketingLetterGrade;
            string economicsLetterGrade;
            string misLetterGrade;
            double accountingCreditPoints;
            double marketingCreditPoints;
            double economicsCreditPoints;
            double misCreditPoints;

            if (accountingGrade >= 90)
            {
                accountingLetterGrade = "A";
            }
            else if (accountingGrade >= 80)
            {
                accountingLetterGrade = "B";
            }
            else if (accountingGrade >= 70)
            {
                accountingLetterGrade = "C";
            }
            else if (accountingGrade >= 60)
            {
                accountingLetterGrade = "D";
            }
            else accountingLetterGrade = "F";
            //assigning credit point values to each letter
            if (accountingLetterGrade == "A")
            {
                accountingCreditPoints = 4;
            }
            else if (accountingLetterGrade == "B")
            {
                accountingCreditPoints = 3;
            }
            else if (accountingLetterGrade == "C")
            {
                accountingCreditPoints = 2;
            }
            else if (accountingLetterGrade == "D")
            {
                accountingCreditPoints = 1;
            }
            else accountingCreditPoints = 0;
            if (marketingGrade >= 90)
            {
                marketingLetterGrade = "A";
            }
            else if (marketingGrade >= 80)
            {
                marketingLetterGrade = "B";
            }
            else if (marketingGrade >= 70)
            {
                marketingLetterGrade = "C";
            }
            else if (marketingGrade >= 60)
            {
                marketingLetterGrade = "D";
            }
            else marketingLetterGrade = "F";
            if (marketingLetterGrade == "A")
            {
                marketingCreditPoints = 4;
            }
            else if (marketingLetterGrade == "B")
            {
                marketingCreditPoints = 3;
            }
            else if (marketingLetterGrade == "C")
            {
                marketingCreditPoints = 2;
            }
            else if (marketingLetterGrade == "D")
            {
                marketingCreditPoints = 1;
            }
            else marketingCreditPoints = 0;


            if (economicsGrade >= 90)
            {
                economicsLetterGrade = "A";
            }
            else if (economicsGrade >= 80)
            {
                economicsLetterGrade = "B";
            }
            else if (economicsGrade >= 70)
            {
                economicsLetterGrade = "C";
            }
            else if (economicsGrade >= 60)
            {
                economicsLetterGrade = "D";
            }
            else economicsLetterGrade = "F";
            if (economicsLetterGrade == "A")
            {
                economicsCreditPoints = 4;
            }
            else if (economicsLetterGrade == "B")
            {
                economicsCreditPoints = 3;
            }
            else if (economicsLetterGrade == "C")
            {
                economicsCreditPoints = 2;
            }
            else if (economicsLetterGrade == "D")
            {
                economicsCreditPoints = 1;
            }
            else economicsCreditPoints = 0;


            if (misGrade >= 90)
            {
                misLetterGrade = "A";
            }
            else if (misGrade >= 80)
            {
                misLetterGrade = "B";
            }
            else if (misGrade >= 70)
            {
                misLetterGrade = "C";
            }
            else if (misGrade >= 60)
            {
                misLetterGrade = "D";
            }
            else misLetterGrade = "F";
            if (misLetterGrade == "A")
            {
                misCreditPoints = 4;
            }
            else if (misLetterGrade == "B")
            {
                misCreditPoints = 3;
            }
            else if (misLetterGrade == "C")
            {
                misCreditPoints = 2;
            }
            else if (misLetterGrade == "D")
            {
                misCreditPoints = 1;
            }
            else misCreditPoints = 0;

            double totalPointsEarned = (accountingCreditPoints*credits) + (economicsCreditPoints*credits) + (marketingCreditPoints*credits) + (misCreditPoints*credits);
            double totalCreditsAttempted = numberOfCourses * credits;
            double gpa = totalPointsEarned / totalCreditsAttempted;



            //output - overall GPA
            //Console.WriteLine(accountingCreditPoints);
            //Console.WriteLine(accountingLetterGrade);
            //Console.WriteLine(marketingCreditPoints);
            //Console.WriteLine(marketingLetterGrade);
            //Console.WriteLine(economicsLetterGrade);
            //Console.WriteLine(economicsLetterGrade);
            //Console.WriteLine(misCreditPoints);
            //Console.WriteLine(misLetterGrade);
            //Console.WriteLine(totalPointsEarned);
            //Console.WriteLine(totalCreditsAttempted);


            Console.WriteLine($"Accounting: {accountingLetterGrade}");
            Console.WriteLine($"Marketing: {marketingLetterGrade}");
            Console.WriteLine($"Economics: {economicsLetterGrade}");
            Console.WriteLine($"MIS: {misLetterGrade}");
            Console.WriteLine($"\t Your GPA is : {gpa}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
