using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Online___Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }
        public string GetAisle()
        {
            string aisleNumber;
            Random rand = new Random();
            aisleNumber = ($"{Manufacturer[0] + rand.Next(1, 24)}");
            return aisleNumber;
        }
    }
}
