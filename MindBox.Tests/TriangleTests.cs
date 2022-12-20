using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.Figures;
using System;

namespace MindBox.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_3and4and5_6returned()
        {
            double x = 3, y = 4, z = 5;
            double expected = 6;

            Triangle triangle = new Triangle(x, y, z);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsTriangleRectangular_3and4and5_trueReturned()
        {
            double x = 3, y = 4, z = 5;
            bool expected = true;

            Triangle triangle = new Triangle(x, y, z);
            bool actual = triangle.IsTriangleRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsTriangleNOTRectangular_8and8and8_falseReturned()
        {
            double x = 8, y = 8, z = 8;
            bool expected = false;

            Triangle triangle = new Triangle(x, y, z);
            bool actual = triangle.IsTriangleRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Error: One or more sides of a triangle less than 0")]
        public void GetArea_LessThanZeroArgs_ArgExReturned()
        {
            double x = -6;
            double y = 5;
            double z = 3;

            Triangle triangle = new Triangle(x, y, z);
            double result = triangle.GetArea();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Error: One of the sides of the triangle is greater than the sum of the other two sides. The Impossible Triangle")]
        public void GetArea_ImpossibleTraingleSides_ArgExReturned()
        {
            double x = 100;
            double y = 15;
            double z = 4;

            Triangle triangle = new Triangle(x, y, z);
            double result = triangle.GetArea();

        }
    }
}
