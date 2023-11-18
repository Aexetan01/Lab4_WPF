using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Ivan
{
    public class RoundedRectangle : Rectangle, IRotate
    {
        public double CornerRadius { get; private set; }

        public RoundedRectangle(Point topLeft, double width, double height, string color, double cornerRadius)
            : base(topLeft, width, height, color)
        {
            CornerRadius = cornerRadius;
        }

        public void Rotate(double angleDegrees)
        {
            CornerRadius += angleDegrees;
        }
    }
}
