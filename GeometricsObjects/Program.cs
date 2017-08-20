using System;
using static System.Console;
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
            // TODO

            GraphicCircle gCircle = new GraphicCircle();
            int? test_String = new int();
            test_String = 24;

            Console.WriteLine($"Anzahl der Kreise = {GraphicCircle.CountCircles}");
            Console.WriteLine("{0}", test_String.ToString());

            ReadKey();
        }
    }
}
