/* Jatin Davis
 * prompt user to input sentence
 * find how many vowels and consonants
 * output answers
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_VowelsAndConsonants_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            int vowels = 0;
            int consonants = 0;
            string userSentence;

            //user input
            Console.WriteLine("Please enter a sentence..");
            userSentence = Console.ReadLine().ToLower();

            //process
            for (int i = 0; i < userSentence.Length; i++)
            {
                char c = userSentence[i];
                if (char.IsLetter(c) && (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'))
                {
                    vowels++;
                }
                else if (char.IsLetter(c))
                {
                    consonants++;
                }

            }
            //output
            Console.WriteLine($"There are {vowels} vowels in the sentence");
            Console.WriteLine($"There are {consonants} consonants in the sentence");

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
