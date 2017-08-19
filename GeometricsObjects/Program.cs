using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new Circle();

            kreis.Radius = 10;

            Console.WriteLine($"Der Kreisradius beträgt: {kreis.Radius}");

            Console.ReadKey();
        }
    }
}
