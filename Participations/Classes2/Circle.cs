using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
