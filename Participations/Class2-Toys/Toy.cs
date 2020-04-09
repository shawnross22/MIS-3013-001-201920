using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Aisle;
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }
        public string GetAisle()
        {
            
            char firstinitial = Manufacturer.ToUpper()[0];
            Random rand = new Random();
            int randomnumber = rand.Next(1, 25);
            Aisle = firstinitial + randomnumber.ToString();
            Console.WriteLine($"Toy is in aisle {Aisle}.");

            return Aisle;
        }



    }
}
