using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Ivan
{
    public class Rectangle : IMove, IResize, IColor
    {
        public string Color { get; set; }
        public Point TopLeft { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle()
        {
            TopLeft = new Point();
            Width = 0;
            Height = 0;
            Color = string.Empty;
        }
        public Rectangle(Point topLeft, double width, double height, string color)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
            Color = color;
        }
        public void Move(double deltaX, double deltaY)
        {
            TopLeft.Move(deltaX, deltaY);
        }

        public void Resize(double scaleFactor)
        {
            Width *= scaleFactor;
            Height *= scaleFactor;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
