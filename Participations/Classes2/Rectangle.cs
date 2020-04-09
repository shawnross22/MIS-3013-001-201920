using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public double CalculateArea()
        {
            return Length * Width;
        }
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
