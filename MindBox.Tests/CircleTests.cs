using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.Figures;
using System;

namespace MindBox.Tests
{   
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_7_153dot93804002589985returned()
        {
            double x = 7;
            double expected = 153.93804002589985;

            Circle circle = new Circle(x);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetArea_0_0returned()
        {
            double x = 0;
            double expected = 0;

            Circle circle = new Circle(x);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Error: Radius cannot be less than zero")]
        public void GetArea_NegativeRadius_ArgExReturned()
        {
            double x = -6;

            Circle circle = new Circle(x);
            double result = circle.GetArea();

        }
    }
}
