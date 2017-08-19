using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    public class Circle
    {
        #region Private Felder

        private double _XCoordinate;
        private double _YCoordinate;
        private int _Radius;

        #endregion

        #region Öffentliche Eigenschaften

        public int Radius
        {
            get => _Radius;
            set
            {
                if (value > 0)
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

        #endregion

        #region Öffentliche Methoden

        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }

        public int Bigger(Circle kreisCircle)
        {
            if (kreisCircle == null || Radius > kreisCircle.Radius) return 1;
            if (Radius < kreisCircle.Radius) return -1;
            return 0;
        }

        #endregion
    }
}
