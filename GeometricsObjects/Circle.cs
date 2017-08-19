using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    class Circle
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
    }
}
