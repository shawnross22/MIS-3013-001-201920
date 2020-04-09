using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length = 15;
            rect1.Width = 10;

            Rectangle rect2 = new Rectangle();
            rect2.Length = 17;
            rect2.Width = 12;

            Circle circ1 = new Circle();
            circ1.Radius = 25;

            Circle circ2 = new Circle();
            circ2.Radius = 10;

            Console.WriteLine($"The rectangle with {rect1.Length} length and {rect1.Width} width has an area of {rect1.CalculateArea()} and a perimeter of {rect1.CalculatePerimeter()}.");
            Console.WriteLine($"The rectangle with {rect2.Length} length and {rect2.Width} width has an area of {rect2.CalculateArea()} and a perimeter of {rect2.CalculatePerimeter()}.");
            Console.WriteLine($"The circle with {circ1.Radius} has an area of {circ1.CalculateArea()} and a perimeter of {circ1.CalculatePerimeter()}.");
            Console.WriteLine($"The circle with {circ2.Radius} has an area of {circ2.CalculateArea()} and a perimeter of {circ2.CalculatePerimeter()}.");

            Console.ReadKey();
        }
    }
}
