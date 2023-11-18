using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Ivan
{
    public class Circle : IMove, IResize, IColor
    {
        public string Color { get; set; }
        public Point Center { get; private set; }
        public double Radius { get; private set; }
        public Circle()
        {
            Color = string.Empty;
            Center = new Point();
            Radius = 0;
        }
        public Circle(Point center, double radius, string color)
        {
            Color = color;
            Center = center;
            Radius = radius;
        }

        public void Move(double deltaX, double deltaY)
        {
            Center.Move(deltaX, deltaY);
        }

        public void Resize(double scaleFactor)
        {
            Radius *= scaleFactor;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
