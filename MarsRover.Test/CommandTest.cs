using System;
using Xunit;
using MarsRover.Model;
using MarsRover.Command;

namespace MarsRover.Test
{
    public class CommandTest
    {
    
        [Fact]
        public void MoveCommandSuccess()
        {
            Location location = new Location();
            location.X = 1;
            location.Y = 2;
            location.Direction = Enums.Direction.N;

            MoveCommand moveCommand = new MoveCommand();
            moveCommand.Execute(location);

            Assert.Equal(1, location.X);
            Assert.Equal(3, location.Y);
            Assert.Equal(Enums.Direction.N, location.Direction);
        }

        [Fact]
        public void TurnLeftCommandSuccess()
        {
            Location location = new Location();
            location.X = 1;
            location.Y = 2;
            location.Direction = Enums.Direction.N;

            TurnLeftCommand turnLeftCommand = new TurnLeftCommand();
            turnLeftCommand.Execute(location);

            Assert.Equal(1, location.X);
            Assert.Equal(2, location.Y);
            Assert.Equal(Enums.Direction.W, location.Direction);
        }

        [Fact]
        public void TurnRightCommandSuccess()
        {
            Location location = new Location();
            location.X = 1;
            location.Y = 2;
            location.Direction = Enums.Direction.N;

            TurnRightCommand turnRightCommand = new TurnRightCommand();
            turnRightCommand.Execute(location);

            Assert.Equal(1, location.X);
            Assert.Equal(2, location.Y);
            Assert.Equal(Enums.Direction.E, location.Direction);
        }
    }
}
