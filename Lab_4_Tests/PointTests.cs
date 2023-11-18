using Lab_4_Ivan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab_4_Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Point_CreatePointWithCoordinates_Success()
        {
            double x = 2.0;
            double y = 3.5;

            Point point = new Point(x, y);

            Assert.AreEqual((x, y), point.GetCoord());
        }

        [TestMethod]
        public void Point_MovePoint_Success()
        {
            Point point = new Point(2.0, 3.5);
            double deltaX = 1.5;
            double deltaY = -0.5;

            point.Move(deltaX, deltaY);

            Assert.AreEqual((2.0 + deltaX, 3.5 + deltaY), point.GetCoord());
        }

        [TestMethod]
        public void Point_ResizePoint_Success()
        {
            Point point = new Point(2.0, 3.5);
            double scaleFactor = 2.0;

            point.Resize(scaleFactor);

            Assert.AreEqual((2.0 * scaleFactor, 3.5 * scaleFactor), point.GetCoord());
        }
    }
}
