/*Jatin Davis
*
* 
* 
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] course = new string[3];
            int[] courseNumber = new int[3];

            for (int i = 0; i < courseNumber.Length; i++)
            {
                Console.WriteLine("Please enter a course name.. i.e. MIS, MATH, CHEM, etc..");
                course[i] = Console.ReadLine();

                Console.WriteLine("Please enter a course number..");
                courseNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < courseNumber.Length; i++)
            {
                Console.WriteLine($"Your class is {course[i]}{courseNumber[i]}");
            }
            
            
            Console.ReadKey();
        }
    }
}
