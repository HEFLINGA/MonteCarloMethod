using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public struct XY
    {
        public double x, y;

        public XY(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public XY(Random obj)
        {
            x = obj.NextDouble();
            y = obj.NextDouble();
        }

        public double X()
        {
            return this.x;
        }

        public double Y()
        {
            return this.y;
        }

        public double Hypotenuse(double x, double y)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)));

            return hypotenuse;
        }
    }
}
