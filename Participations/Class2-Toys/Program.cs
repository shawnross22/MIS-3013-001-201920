using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "lego";
            toy1.Name = "car";
            toy1.Price = 5.50;

            Toy toy2 = new Toy();
            toy2.Manufacturer = "spalding";
            toy2.Name = "basketball";
            toy2.Price = 10.75;

            ToyBox toybox1 = new ToyBox();
            toybox1.Toys = new List<Toy>();
            toybox1.Toys.Add(toy1);
            toybox1.Toys.Add(toy2);


            toy1.GetAisle();
            toy2.GetAisle();

            Console.ReadKey();

        }
    }
}
