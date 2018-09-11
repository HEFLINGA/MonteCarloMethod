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
            // Start of array/ Prompt user for array size
            Console.WriteLine("Input array size");
            int input = int.Parse(Console.ReadLine());

            // Initialize structs
            Random rnd = new Random();
            XY hyp = new XY();
            
            // Initialize array/array length/counter
            double[,] arr = new double[input, 2];
            int len = arr.Length - input;
            int counter = 0;

            // Loop for random X and Y coords in multiDem array
            for (int i = 0; i < len; ++i)
            {
                XY rand = new XY(rnd);
                arr[i, 0] = rand.X();
                arr[i, 1] = rand.Y();
                Console.WriteLine($"X: {rand.X()}.  Y: {rand.Y()}");                
                Console.WriteLine($"Hyp: {hyp.Hypotenuse(rand.X(), rand.Y())}");

                // Increments counter for hypotenuse inside of circle
                if (hyp.Hypotenuse(rand.X(), rand.Y()) <= 1)
                {
                    counter++;
                }                
            }

            // Step 5 of Monte Carlo
            double coord = 0;
            double length = len;
            double total = counter;
            coord += total / length;
            double coordTotal = coord * 4;

            // Writes all results of counter, result, and difference from pi
            Console.WriteLine($"Counter: {counter}");
            Console.WriteLine($"Result: {coordTotal}");
            double diff = Math.Abs(coordTotal - Math.PI);
            Console.WriteLine($"Difference: {diff}");

            Console.WriteLine($" ");


        }
    }
}
