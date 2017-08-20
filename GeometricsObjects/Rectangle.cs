using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    public class Rectangle : GeometricObject
    {
        #region Statische Klassenfelder

        private static int _CountRectangles;

        #endregion

        #region Private Felder

        private double _XCoordinate;
        private double _YCoordinate;

        #endregion

        #region Konstruktoren

        public Rectangle() : this(0, 0, 0, 0) { }

        public Rectangle(int length, int width) : this(length, width, 0, 0) { }

        public Rectangle(int length, int width, double x, double y)
        {
            Length = length;
            Width = width;
            XCoordinate = x;
            YCoordinate = y;
            Rectangle._CountRectangles++;
        }
        #endregion

        #region Eigenschaften

        public  double XCoordinate { get => _XCoordinate; set => _XCoordinate = value; }
        public  double YCoordinate { get => _YCoordinate; set => _YCoordinate = value; }
        public static int CountRectangles { get => _CountRectangles; }

        private int _Length;
        public int Length
        {
            get { return _Length; }
            set
            {
                if (value >= 0)
                    _Length = value;
                else
                    Console.WriteLine("Unzulässige negative Länge.");
            }
        }

        private int _Width;
        public int Width
        {
            get { return _Width; }
            set
            {
                if (value >= 0)
                    _Width = value;
                else
                    Console.WriteLine("Unzulässige negative Breite.");
            }
        }

        #endregion

        #region Instanzmethoden

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetCircumference()
        {
            return (2 * Length) + (2 * Width);
        }



        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void Move(double dx, double dy, int dWidth, int dLength)
        {
            Move(dx, dy);
            Width += dWidth;
            Length += dLength;
        }

        public int Bigger(Rectangle rechteckRectangle)
        {
            if (rechteckRectangle == null || GetArea() > rechteckRectangle.GetArea()) return 1;
            if (GetArea() < rechteckRectangle.GetArea()) return -1;
            return 0;
        }

        public override string ToString()
        {
            return "Rectangle, L=" + Length + ",B=" + Width + ",Fläche=" + GetArea();
        }

        #endregion

        #region Klassenmethoden

        public static double GetArea(int length, int width)
        {
            return length * width;
        }

        public static double GetCircumference(int length, int width)
        {
            return (2 * length) + (2 * width);
        }

        public static int Bigger(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle1 == null && rectangle2 == null) return 0;
            if (rectangle1 == null) return -1;
            if (rectangle2 == null) return 1;
            if (rectangle1.GetArea() > rectangle2.GetArea()) return 1;
            if (rectangle1.GetArea() < rectangle2.GetArea()) return -1;

            return 0;
        }

        #endregion

        #region Destruktor

        ~Rectangle() { }

        #endregion
    }
}
