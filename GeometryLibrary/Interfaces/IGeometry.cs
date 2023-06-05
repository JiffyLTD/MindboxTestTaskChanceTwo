namespace GeometryLibrary.Interfaces
{
    internal interface IGeometry
    {
        /// <summary>
        /// Вычисление площади круга по радиусу
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        abstract static double GetCircleAreaByRadius(double r);

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам
        /// </summary>
        /// <param name="a">Длина первой стороны треугольника</param>
        /// <param name="b">Длина второй стороны треугольника</param>
        /// <param name="c">Длина третьей стороны треугольника</param>
        /// <returns>Площадь треугольника</returns>
        abstract static double GetTriangleAreaBySides(double a, double b, double c);
    }
}
