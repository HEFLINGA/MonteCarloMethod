using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array size");
            int input = int.Parse(Console.ReadLine());
            XY hyp = new XY();
            Random rnd = new Random();

            double[,] arr = new double[input, 2];
            int len = arr.Length - input;
            int counter = 0;

            for (int i = 0; i < len; ++i)
            {
                XY rand = new XY(rnd);
                arr[i, 0] = rand.X();
                arr[i, 1] = rand.Y();
                Console.WriteLine($"X: {rand.X()}.  Y: {rand.Y()}");                
                Console.WriteLine($"Hyp: {hyp.Hypotenuse(rand.X(), rand.Y())}");

                if (hyp.Hypotenuse(rand.X(), rand.Y()) <= 1)
                {
                    counter++;
                }                
            }

            double coord = 0;
            double length = len;
            double counter1 = counter;
            coord += counter1 / length;
            double coord1 = coord * 4;

            Console.WriteLine($"Counter: {counter}");
            Console.WriteLine($"Result: {coord1}");
            double diff = Math.Abs(coord1 - Math.PI);
            Console.WriteLine($"Difference: {diff}");

            Console.WriteLine($" ");


        }
    }
}
