using System;

namespace MindBox.Figures
{
    public class Triangle : Figure
    {
        double AB { get; }
        double BC { get; }
        double CA { get; }

        public Triangle(double ab, double bc, double ca)
        {
            CheckTriangle(ab, bc, ca);

            AB = ab;
            BC = bc;
            CA = ca;
        }

        private void CheckTriangle(double ab, double bc, double ca)
        {
            if (ab < 0 || bc < 0 || ca < 0) throw new ArgumentException("Error: One or more sides of a triangle less than 0");
            if (ab + bc <= ca || ab + ca <= bc || bc + ca <= ab)
                throw new ArgumentException("Error: One of the sides of the triangle is greater than the sum of the other two sides. The Impossible Triangle");
        }

        /// Get the area of the triangle
        public override double GetArea()
        {
            double p = (AB + BC + CA) / 2;
            double area = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
            return area;
        }

        /// Check that the triangle is rectangular
        public bool IsTriangleRectangular()
        {
            return (Math.Pow(AB, 2) == (Math.Pow(BC, 2) + Math.Pow(CA, 2))) ||
                (Math.Pow(BC, 2) == (Math.Pow(AB, 2) + Math.Pow(CA, 2))) ||
                (Math.Pow(CA, 2) == (Math.Pow(AB, 2) + Math.Pow(BC, 2)));
        }
    }
}
