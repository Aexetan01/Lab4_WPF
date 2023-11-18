using Lab_4_Ivan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Tests
{
    [TestClass]
    public class RoundedRectangleTests
    {
        [TestMethod]
        public void RoundedRectangle_CreateRoundedRectangle_Success()
        {
            Point topLeft = new Point(2.0, 3.5);
            double width = 4.0;
            double height = 2.5;
            string color = "#000000";
            double cornerRadius = 5;

            RoundedRectangle roundedRectangle = new RoundedRectangle(topLeft, width, height, color, cornerRadius);

            Assert.AreEqual((topLeft.GetCoord(), width, height, color, cornerRadius),
                (roundedRectangle.TopLeft.GetCoord(), roundedRectangle.Width, roundedRectangle.Height, roundedRectangle.Color, roundedRectangle.CornerRadius));
        }

        [TestMethod]
        public void RoundedRectangle_RotateRoundedRectangle_Success()
        {
            Point topLeft = new Point(2.0, 3.5);
            double width = 4.0;
            double height = 2.5;
            string color = "#000000";
            double cornerRadius = 5;

            double angleDegrees = 10;

            RoundedRectangle roundedRectangle = new RoundedRectangle(topLeft, width, height, color, cornerRadius);

            roundedRectangle.Rotate(angleDegrees);

            Assert.AreEqual(cornerRadius + angleDegrees, roundedRectangle.CornerRadius);
        }
    }
}
