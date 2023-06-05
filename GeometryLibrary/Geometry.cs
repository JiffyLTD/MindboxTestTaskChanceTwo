using GeometryLibrary.Interfaces;

namespace GeometryLibrary
{
    public class Geometry : IGeometry
    {
        public static double GetCircleAreaByRadius(double r)
        {
           return Math.PI * r * r;  
        }

        public static double GetTriangleAreaBySides(double a, double b, double c)
        {
            double semiPerimeter = (a + b + c) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }
    }
}
