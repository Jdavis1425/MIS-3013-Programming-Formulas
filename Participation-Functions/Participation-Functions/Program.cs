//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation would you like to run? Coin Flip or Grades?");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "coin flip")
            {
               Participation1();
            }
            else if (userChoice == "grades")
            {
                Participation3();
            }
            Console.ReadKey();
            
        }
        static void Participation1()
        {
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;

            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;

            if (usersGuessAsString == "Heads")
            {
                usersGuess = HEADS_VALUE;
            }
            else if (usersGuessAsString == "Tails")
            {
                usersGuess = TAILS_VALUE;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later");
                Console.ReadKey();
                return;
            }

            Random rand = new Random();


            int randomNumber = rand.Next(0, 2);

            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {usersGuessAsString}");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {usersGuessAsString}");
                }
            }

            Console.ReadKey();
        }
        static void Participation3()
        {
            { 
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            List<double> mis3013Grades = new List<double>();
            mis3013Grades.Add(.75);
            mis3013Grades.Add(.55);
            mis3013Grades.Add(.95);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(.95);
            mis3033Grades.Add(.25);
            mis3033Grades.Add(1.00);

            List<double> mis2113Grades = new List<double>();
            mis2113Grades.Add(.35);
            mis2113Grades.Add(.25);
            mis2113Grades.Add(.55);

            studentGrades.Add("MIS3013", mis3013Grades);
            studentGrades.Add("MIS3033", mis3033Grades);
            studentGrades.Add("MIS2113", mis2113Grades);

            foreach (var courseCode in studentGrades.Keys)
            {
                List<double> currentGrades = studentGrades[courseCode];

                //double courseCodeAverage = 0;

                //foreach (double grade in currentGrades)
                //{
                //    courseCodeAverage += grade;
                //}

                double courseCodeAverage = Average(currentGrades);

                Console.WriteLine($"The average for {courseCode} is {(courseCodeAverage / currentGrades.Count).ToString("P")}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Provided a list of double values, this function will calculate the average
        /// </summary>
        /// <param name="values">A List of double values to calculate the average of</param>
        /// <returns>Return the average of the values</returns>
        double Average(List<double> values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }

            return sum / values.Count;
        } }
    }
}