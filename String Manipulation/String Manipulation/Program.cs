using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  01234
            string firstName = "Jatin";
            string lastName = "Davis";

            Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your first name.");
            Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your last name.");

            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            //Console.WriteLine(firstName.ToUpper()[0]);
            //Console.WriteLine(firstName.ToUpper()[1]);
            //Console.WriteLine(firstName.ToUpper()[2]);
            //Console.WriteLine(firstName.ToUpper()[3]);
            //Console.WriteLine(firstName.ToUpper()[4]);

            //firstName = firstName.ToUpper();
            //Output every character of the firstname on a seperate line with BIG LETTERS
            for (int i = 0; i < firstName.Length; i++)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);


            }
            //for each loop
            //foreach (var currentLetter in firstName)
            {
                //Console.WriteLine(currentLetter);

            }

            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i=i+2)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);


            }
            Console.WriteLine();
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");

            string name = firstName + " " + lastName;
            var pieces = name.Split(' ');
            string fName = name.Substring(0, firstName.Length);
            fName = "     " + fName + "       ";
            fName = fName.Trim();
            for (int i = name.Length-1; i >=0; i--)
            {
                Console.Write(name[i]);
            }
            



            Console.ReadKey();

        }
    }
}
