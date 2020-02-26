/* Jatin Davis
 * college charges 12,000 per semester
 * will increase by 5% each year for 7 years
 * display projected tuition amount for next 7 years
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_TuitionIncrease_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            int initialTuition = 12000;
            double tuitionPerSemester = initialTuition;

            //process
            for (int i = 1; i < 8; i++)
            {
                tuitionPerSemester = tuitionPerSemester + tuitionPerSemester * (5/100.0);
                Console.WriteLine("The tuition after year {0} will be {1}.", i ,tuitionPerSemester.ToString("$#,###"));
            }

            //output - The tuition after year 1 will be $12,600.
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
