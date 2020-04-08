//Jatin Davis
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Online___Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            ToyBox tb = new ToyBox();

            toy1.Manufacturer = "Hasbro";
            toy1.Name = "Board Game";
            toy1.Price = 10;
            tb.Toys = new List<Toy>();
            tb.Toys.Add("Doll");

            

            Console.ReadKey();
        }
    }
}
