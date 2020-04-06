using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipationOnline__Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.FirstName = "Jatin";
            stud1.LastName = "Davis";
            stud1.CourseGrade.Add("A");
            stud1.CourseName.Add("MIS-3013");
            stud1.CourseGrade.Add("B");
            stud1.CourseName.Add("MIS-3313");
            stud1.CalculateGPA();



            Console.ReadKey();
        }
    }
}
