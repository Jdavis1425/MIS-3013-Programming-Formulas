using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of type int with a size of 3
            int[] studentIds = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" }; //these two arrays are parallel (e.g. value 1 in ids correlates to value 1 in names


            //[0]    [1]    [2]
            //[Adam][Katie][Micah]
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            //INDEX OUT OF RANGE BECAUSE WE ONLY HAVE SPACE FOR 3 VALUES -- studentIds[3] = 4;

            for (int i = 0; i < studentIds.Length; i++) //could also do studentNames.Length as they are PARALLEL
            {
                Console.WriteLine($"Student with ID {studentIds[0]} has a name of {studentNames[0]}");

            }

            //DO SAME THING BUT WITH LISTS

            List<int> studIds = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>() { "Lakin", "Grant", "Eric" };
            //studNames.Add("Lakin");
            //studNames.Add("Grant");
            //studNames.Add("Eric");

            for (int i = 0; i < studIds.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIds[0]} has a name of {studNames[0]}");

            }

            //COMBINE ARRAY DATA AND LIST DATA INTO DICTIONARY

            Dictionary<int, string> students = new Dictionary<int, string>();

            for (int i = 0; i < studentIds.Length; i++)
            {
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studentIds[i], studentNames[i]);
                }
            }

            Console.WriteLine("MADE IT THRU ALIVE");

            Console.WriteLine($"The dictionary has {students.Count()} students");
            Console.ReadKey();
        }
    }
}
