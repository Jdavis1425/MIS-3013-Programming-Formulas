//Jatin Davis


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_3
{
    class Program
    {
        static void Main(string[] args)
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
        static double Average(List<double> values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }

            return sum / values.Count;
        }
        }
    }
}
