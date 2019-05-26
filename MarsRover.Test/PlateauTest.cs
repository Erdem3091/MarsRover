using System;
using Xunit;
using MarsRover.Model;

namespace MarsRover.Test
{
    public class PlateauTest
    {
        [Fact]
        public void CreatePlateauThrowInvalidCoordinateException()
        {
            try
            {
                var Plateau = new Plateau(-1, 5);
            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("Invalid Plateau Coordinate", ex.Message);

            }

        }

        [Fact]
        public void CreatePlateauSuccess()
        {
            var Plateau = new Plateau(5, 5);
            Assert.Equal(5, Plateau.X);
            Assert.Equal(5, Plateau.Y);

        }
    }
}
