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
    public class RectangleTests
    {
        [TestMethod]
        public void Rectangle_CreateRectangle_Success()
        {
            Point topLeft = new Point(2.0, 3.5);
            double width = 4.0;
            double height = 2.5;
            string color = "#000000";

            Rectangle rectangle = new Rectangle(topLeft, width, height, color);

            Assert.AreEqual((topLeft.GetCoord(), width, height, color), 
                (rectangle.TopLeft.GetCoord(), rectangle.Width, rectangle.Height, rectangle.Color));
        }

        [TestMethod]
        public void Rectangle_ResizeRectangle_Success()
        {
            Rectangle rectangle = new Rectangle(new Point(2.0, 3.5), 4.0, 2.5, "#000000");
            double scaleFactor = 2.0;

            rectangle.Resize(scaleFactor);

            Assert.AreEqual((4.0 * scaleFactor, 2.5 * scaleFactor), (rectangle.Width, rectangle.Height));
        }


        [TestMethod]
        public void Rectangle_Move_Success()
        {
            Rectangle rectangle = new Rectangle(new Point(2.0, 3.5), 4.0, 2.5, "#000000");
            double moveDeltaX = 5;
            double moveDeltaY = 6;

            rectangle.Move(moveDeltaX, moveDeltaY);

            Assert.AreEqual((2.0 + 5, 3.5 + 6), (rectangle.TopLeft.GetCoord()));
        }

        [TestMethod]
        public void Rectangle_ChangeColor_Success()
        {
            Rectangle rectangle = new Rectangle(new Point(2.0, 3.5), 4.0, 2.5, "#000000");
            string newColor = "#FFFFFF";

            rectangle.ChangeColor(newColor);

            Assert.AreEqual(newColor, rectangle.Color);
        }
    }
}
