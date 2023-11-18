using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Ivan
{
    public class Point : IMove, IResize
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public (double, double) GetCoord()
        {
            return (X, Y);
        }

        public void Move(double deltaX, double deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void Resize(double scaleFactor)
        {
            X *= scaleFactor;
            Y *= scaleFactor;
        }
    }
}
