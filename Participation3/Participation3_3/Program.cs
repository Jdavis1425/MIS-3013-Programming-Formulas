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
            mis3013Grades.Add(0.95);
            mis3013Grades.Add(0.75);
            mis3013Grades.Add(0.85);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(0.90);
            mis3033Grades.Add(0.70);
            mis3033Grades.Add(0.80);

            List<double> mis2113Grades = new List<double>();
            mis2113Grades.Add(0.65);
            mis2113Grades.Add(0.70);
            mis2113Grades.Add(0.81);

            studentGrades.Add("MIS3013", mis3013Grades);
            studentGrades.Add("MIS3033", mis3033Grades);
            studentGrades.Add("MIS2113", mis2113Grades);

            foreach (var courseCode in studentGrades.Keys)
            {
                List<double> currentGrades = studentGrades[courseCode];
                double courseCodeAverage = 0;

                foreach (var grade in currentGrades)
                {
                    courseCodeAverage += grade;
                }
                Console.WriteLine($"The average for {courseCode} is {(courseCodeAverage / currentGrades.Count).ToString("P2")}");
            }
            Console.ReadKey();
        }
    }
}
