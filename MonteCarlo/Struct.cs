using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    struct Coordinate
    {
        public double x;
        public double y;

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate(Random obj)
        {
            x = obj.NextDouble();
            y = obj.NextDouble();
        }

        public double Hypotenuse(double x, double y)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return hypotenuse;
        }
    }
}
