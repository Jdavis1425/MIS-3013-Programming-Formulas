/*Jatin Davis
 * prompt the user to enter what type of item they are purchasing, the quantity of the item, and the price for the item.
 * Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax)
 * output all 3 to the user.
 * Assume that the sales tax for your application is 8.5% (create a constant to store this value and use the constant in your calculations).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_SalesTotal_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            
            string product;
            int quantity;
            double price;

            //user input
            Console.WriteLine("What type of item are you purchasing?");
            product = Console.ReadLine();

            Console.WriteLine("How many are you purchasing?");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"What is the price for each {product}?");
            price = Convert.ToDouble(Console.ReadLine());

            //process - Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax)
            const double taxRate = .085;

            double subtotal = price * quantity;
            double purchaseTax = taxRate*subtotal;
            double salesTotal = purchaseTax + subtotal;

            //output- subtotal, sales tax, and sales total
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Sales Tax: ${purchaseTax}");
            Console.WriteLine($"Total: ${salesTotal}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
