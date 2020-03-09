//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Jatin Davis", "MIS-3013", "03/09/2020");

            double result = 0;
            string newCalculation = "";
            do
            {
                Console.WriteLine("What type of calculation would you like to do? i.e. Addition, Subtraction, Multiplication, Division");
                string userInput = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter two values for your calculation..");
                double v1 = Convert.ToDouble(Console.ReadLine());
                double v2 = Convert.ToDouble(Console.ReadLine());

                
                Console.WriteLine("Would you like to perform another calculation?");
                newCalculation = Console.ReadLine().ToLower();

                if (newCalculation=="yes")
                {
                    Console.WriteLine("Would you like to use your result as the first value in your new calculation? Yes or No");
                    string userResult1 = Console.ReadLine().ToLower();

                    if (userResult1=="yes")
                    {
                        v1 = result;
                    }
                }

                if (userInput == "addition")
                {
                    result = Add(v1, v2);
                }
                else if (userInput == "subtraction")
                {
                    result = Subtract(v1, v2);
                }
                else if (userInput == "multiplication")
                {
                    result = Multiply(v1, v2);
                }
                else if (userInput == "division")
                {
                    result = Divide(v1, v2);
                }


            } while (newCalculation == "yes");

            Console.WriteLine($"Your calculation resulted in {result}");

            Console.ReadKey();
        }
        static double Add(double v1, double v2)
        {
            double sum = 0;
            sum = v1 + v2;
            return sum;
        }
        static double Subtract(double v1, double v2)
        {
            double difference = 0;
            difference = v1 - v2;
            return difference;
            
        }
        static double Multiply(double v1, double v2)
        {
            double product = 0;
            product = v1 * v2;
            return product;
        }
        static double Divide(double v1, double v2)
        {
            double quotient = 0;
            quotient = v1 / v2;
            return quotient;
        }
        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}");
        }

    }
}
