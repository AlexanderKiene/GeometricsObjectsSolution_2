using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    public class Circle
    {
        #region Statische Klassenfelder

        protected static int _CountCircles;

        #endregion

        #region Private Felder

        private double _XCoordinate;
        private double _YCoordinate;
        protected int _Radius;

        #endregion

        #region Konstruktoren

        public Circle() : this(0, 0, 0) { }
        

        public Circle(int radius) : this(radius, 0, 0) { }

        public Circle(int radius, double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
            Radius = radius;
            _CountCircles++;
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

        #region Instanzmethoden

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

        public override string ToString()
        {
            return "Circle, R=" + Radius + ",Fläche=" + GetArea();
        }

        #endregion

        #region Klassenmethoden

        public static double GetArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1 == null && kreis2 == null) return 0;
            if (kreis1 == null) return -1;
            if (kreis2 == null) return 1;
            if (kreis1.Radius > kreis2.Radius) return 1;
            if (kreis1.Radius < kreis2.Radius) return -1;

            return 0;
        }

        #endregion

        #region Destruktor

        ~Circle() { }

        #endregion
    }
}
