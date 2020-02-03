//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count to? >>");
            //string input = console.readline();
            //int threshold = convert.toint32(input);
            int threshold = Convert.ToInt32(Console.ReadLine());

            //could also use i<101
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }

            double sum = 0;
            string answer;

            do
            {
                Console.WriteLine("Please give us a # to add >>");
                int number = Convert.ToInt32(Console.ReadLine());
                //sum = sum + number;
                sum += number;

                Console.WriteLine("Do you have another # to add? (Y,N) >>");
                answer = Console.ReadLine();


            } while (answer == "Y");
            //} while (answer != "N");
            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}");
            

            Console.ReadKey();
        }
    }
}
