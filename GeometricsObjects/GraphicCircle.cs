using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    class GraphicCircle : Circle
    {
        #region Private Felder

        private double _XCoordinate;
        private double _YCoordinate;
        private int _Radius;

        #endregion

        #region Konstruktoren

        public GraphicCircle() : base(0, 0, 0) { }


        public GraphicCircle(int radius) : base(radius, 0, 0) { }

        public GraphicCircle(int radius, double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
            Radius = radius;
            Circle._CountCircles++;
        }
#endregion
        #region Eigenschaften

        public int Radius
        {
            get => _Radius;
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                }
                else
                {
                    Console.WriteLine("Kein negativen Wert!");
                }
            }
        }

        public double XCoordinate { get => _XCoordinate; set => _XCoordinate = value; }
        public double YCoordinate { get => _YCoordinate; set => _YCoordinate = value; }
        public static int CountCircles { get => _CountCircles; }

        #endregion

        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet.");
        }
    }
}
