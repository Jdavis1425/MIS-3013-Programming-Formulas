/* Jatin Davis
 * prompt user to input sentence, convert to uppercase
 * replace letters a, e, h, s, t, and u with appropriate glyphs
 * use replace()
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_I337Converter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a sentence..");
            string userSentence = Console.ReadLine().ToUpper();

            string newSentence = userSentence.Replace("A", "@").Replace("E", "3").Replace("H", "|-|").Replace("S", "$").Replace("T", "7").Replace("U", "|_|");
            

            Console.WriteLine(newSentence);
            Console.ReadKey();
        }
    }
}
