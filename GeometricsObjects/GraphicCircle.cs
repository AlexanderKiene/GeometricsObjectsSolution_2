using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsObjects
{
    class GraphicCircle : Circle
    {

        #region Konstruktoren

        public GraphicCircle() : base(0, 0, 0) { }


        public GraphicCircle(int radius) : base(radius, 0, 0) { }

        public GraphicCircle(int radius, double x, double y) : base(radius, x, y) { }
        
        #endregion

        #region Instanzmethoden

        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet");
        }

        #endregion

    }
}
