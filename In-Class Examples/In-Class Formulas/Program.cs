﻿//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a string named firstName
            string firstName;

            //Assign a value to firstName 
            firstName = "Jatin";

            //Create an int named favoriteNumber and assign your favorite number
            int favoriteNumber = 4;

            double crazyNumber = 7.592045 * favoriteNumber;

            string lastName = "Davis";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has favorite number of " + favoriteNumber + " \nwhich equates to a crazy number of " + crazyNumber);

            //MAKE IT DYNAMIC 
            Console.WriteLine("Please enter your first name: >>");
            firstName = Console.ReadLine();
           
            Console.WriteLine("Please enter your last name: >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: >>");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(favoriteNumberAsString);
            //favoriteNumber=Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine(fullName + " has favorite number of " + favoriteNumber + " \nwhich equates to a crazy number of " + crazyNumber);

            Console.ReadKey();
        }
    }
}
