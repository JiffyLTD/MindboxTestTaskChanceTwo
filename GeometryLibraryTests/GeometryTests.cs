using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryTests
{
    public class GeometryTests
    {
        [Fact]
        public void GetCircleAreaByRadiusTest()
        {
            // Arrange
            var radius = 5.0;
            var expectedArea = Math.PI * radius * radius;

            // Act
            var actualArea = Geometry.GetCircleAreaByRadius(radius);

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void GetTriangleAreaBySidesTest()
        {
            // Arrange
            var a = 3.0;
            var b = 4.0;
            var c = 5.0;
            var semiPerimeter = (a + b + c) / 2;
            var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            // Act
            var actualArea = Geometry.GetTriangleAreaBySides(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
    }
}

