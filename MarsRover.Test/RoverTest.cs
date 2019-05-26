using System;
using Xunit;
using MarsRover.Model;
using MarsRover.Enums;

namespace MarsRover.Test
{
    public class RoverTest
    {
        [Fact]
        public void CreateRoverThrowPositionOutOfPlateauException()
        {

            try
            {
                var Rover = new Rover(-1, 2, "N", new Plateau(5, 5));
            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("Rover position is out of plateau", ex.Message);

            }

        }

        [Fact]
        public void CreateRoverInvalidDirectionException()
        {

            try
            {
                var Rover = new Rover(1, 2, "P", new Plateau(5, 5));
            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("Invalid Direction", ex.Message);

            }

        }

        [Fact]
        public void RoverCantMoveBecausePlateauBorderException()
        {

            try
            {
                var Rover = new Rover(1, 2, "N", new Plateau(2, 2));
                Rover.ReadCommands("M");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("Rover Can't Move Because of Plateau Border", ex.Message);

            }

        }

        [Fact]
        public void CreateRoverSuccess()
        {
            var Rover = new Rover(1, 2, "E", new Plateau(5, 5));
            Assert.Equal(1, Rover.Location.X);
            Assert.Equal(2, Rover.Location.Y);
            Assert.Equal(Direction.E, Rover.Location.Direction);

            Assert.Equal(5, Rover.Plateau.X);
            Assert.Equal(5, Rover.Plateau.Y);
        }


    }
}
