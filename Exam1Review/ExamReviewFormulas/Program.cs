/*
 * @Author: Jatin Davis
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> allDaNumbers = new List<double>();
            string usersAnswerAsString;
            double usersAnswerAsDouble;
            string enterAnotherNumber;

            //complex do while loop
            do
            {
                Console.WriteLine("Please enter a number >>");
                usersAnswerAsString = Console.ReadLine();
                bool isAValidNumber;

                isAValidNumber = double.TryParse(usersAnswerAsString, out usersAnswerAsDouble);

                while (isAValidNumber == false)
                {
                    Console.WriteLine("Please enter a valid number >>");
                    usersAnswerAsString = Console.ReadLine();

                    isAValidNumber = double.TryParse(usersAnswerAsString, out usersAnswerAsDouble);
                }

                //usersAnswerAsDouble = Convert.ToDouble(usersAnswerAsString); //Before we did tryparse
                allDaNumbers.Add(usersAnswerAsDouble);

                if (usersAnswerAsString[usersAnswerAsString.Length - 1] == '!') // very last character is a ! 

                    Console.WriteLine("Do you want to enter another number? >>");
                enterAnotherNumber = Console.ReadLine();
            } while (enterAnotherNumber.ToUpper()[0].ToString() == "Y");


            double bankAccountBalance = 4.58;
            string newString = usersAnswerAsString.Replace("dumb", "brilliant").Replace("brilliant", "dumb");
            Console.WriteLine(bankAccountBalance);
            Console.WriteLine($"Your bank account balance is {bankAccountBalance.ToString("C5")}.");

            //while (enterAnotherNumber == "yes")
            //{
            //    Console.WriteLine("Please enter a number >>");
            //    usersAnswerAsString = Console.ReadLine();
            //    usersAnswerAsDouble = Convert.ToDouble(usersAnswerAsString);
            //    allDaNumbers.Add(usersAnswerAsDouble);

            //    Console.WriteLine("Do you want to enter another number? >>");
            //    enterAnotherNumber = Console.ReadLine();
            //}


        }
    }
}