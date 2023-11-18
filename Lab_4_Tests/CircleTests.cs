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
    public class CircleTests
    {
        [TestMethod]
        public void Circle_CreateCircle_Success()
        {
            Point center = new Point(2.0, 3.5);
            double radius = 5;
            string color = "#000000";

            Circle circle = new Circle(center, radius, color);

            Assert.AreEqual((center.GetCoord(), radius, color), (circle.Center.GetCoord(), radius, color));
        }

        [TestMethod]
        public void Circle_ResizeCircle_Success()
        {
            Point center = new Point(2.0, 3.5);
            double radius = 5;
            string color = "#000000";
            Circle circle = new Circle(center, radius, color);

            double scaleFactor = 5;

            circle.Resize(scaleFactor);

            Assert.AreEqual((radius * scaleFactor), circle.Radius);
        }


        [TestMethod]
        public void Circle_Move_Success()
        {
            Point center = new Point(2.0, 3.5);
            double radius = 5;
            string color = "#000000";

            Circle circle = new Circle(center, radius, color);
            double moveDeltaX = 5;
            double moveDeltaY = 6;

            circle.Move(moveDeltaX, moveDeltaY);

            Assert.AreEqual((2.0 + 5, 3.5 + 6), (circle.Center.GetCoord()));
        }

        [TestMethod]
        public void Circle_ChangeColor_Success()
        {
            Point center = new Point(2.0, 3.5);
            double radius = 5;
            string color = "#000000";
            Circle circle = new Circle(center, radius, color);
            string newColor = "#FFFFFF";

            circle.ChangeColor(newColor);

            Assert.AreEqual(newColor, circle.Color);
        }
    }
}
