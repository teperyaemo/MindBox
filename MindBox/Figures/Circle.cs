using System;

namespace MindBox.Figures
{
    public class Circle : Figure
    {
        private readonly double radius;

        public Circle(double radius)
        {   
            this.radius = radius < 0 ? throw new ArgumentException("Error: Radius cannot be less than zero") : radius;
        }

        /// Get the area of the circle
        public override double GetArea() =>
            Math.PI * Math.Pow(radius,2);
    }
}
