//Jatin Davis
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
            

        }

        

        /// <summary>
        /// provided a list of double values, this function will calculate the average
        /// </summary>
        /// <param name="values"> a list of double values to calculate the average of</param>
        /// <returns> return the average of the values </returns>
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
