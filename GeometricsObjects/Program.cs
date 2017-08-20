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

            Console.WriteLine($"Anzahl der Kreise = {GraphicCircle.CountCircles}");

            ReadKey();
        }
    }
}
