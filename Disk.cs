using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_38
{
    class Disk : IShape
    {
        public double Radius { get; set; }

        public Disk(double radius) //Констурктор
        {
            Radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
