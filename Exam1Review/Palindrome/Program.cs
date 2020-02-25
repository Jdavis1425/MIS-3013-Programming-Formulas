//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define variables
            bool isPalindrome;
            string userWord, userWordReversed=""; //2nd one needs value since we will be adding to it. not assigning like the others
            int index;

            //user input- get word or phrase
            Console.WriteLine("Please enter a word or phrase..");
            userWord = Console.ReadLine().ToLower();
            index = userWord.Length-1; //to get index to start at last spot of input
            //process- determine whether palindrome or not
            /*   0  1  2    length=3, last character in word/stirng = length-1. 
             *   M  O  M
             */

            //if youre not using the control variables, ie index, whatever is changing in the loop, youre probably wrong

            while (index>=0)
            {
                userWordReversed += userWord[index];

                index--;
            }

            if (userWordReversed == userWord)
            {
                Console.WriteLine($"The word {userWordReversed} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"The word {userWord} reversed is {userWordReversed} and therefore not a Palindrome.");

            }

            //output- was word palindrome or not

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
