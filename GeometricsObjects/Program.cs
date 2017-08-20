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
            // TODO

            Circle kreis1 = new Circle(12);
            Circle kreis2 = new Circle(30);

            Console.WriteLine($"Grösster Kreis = {Circle.Bigger(kreis1, kreis2)}");

            Console.ReadKey();
        }
    }
}
