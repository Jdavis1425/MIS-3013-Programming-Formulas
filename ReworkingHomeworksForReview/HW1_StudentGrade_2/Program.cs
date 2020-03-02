/*Jatin Davis
 * prompt the user to enter their first name, last name, student id number and overall percentage grade for quizzes, participations, homeworks, midterm and final exam.
 * Use the percentages from this class to calculate their final grade and output it as a percent. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_StudentGrade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string firstName;
            string lastName;
            int studentID;
            double quizzesGrade = 0;
            double participationGrade = 0;
            double homeworkGrade = 0;
            double midtermGrade = 0;
            double finalExam = 0;

            //user input

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your Student ID number?");
            studentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Quiz Grade?");
            quizzesGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Participation Grade?");
            participationGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Homework Grade?");
            homeworkGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Midterm Exam Grade?");
            midtermGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your Final Exam Grade?");
            finalExam = Convert.ToDouble(Console.ReadLine());

            //process - calculate final grade
            double studentGrade;

            studentGrade = (quizzesGrade + participationGrade + homeworkGrade + midtermGrade + finalExam) / 5;

            //final grade as percentage
            Console.WriteLine($"{firstName} {lastName}, your total grade is {studentGrade}% ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
