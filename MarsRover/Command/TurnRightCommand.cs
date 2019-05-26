using MarsRover.Enums;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Command
{
    public class TurnRightCommand : ICommand
    {
        public void Execute (Location roverLocation)
        {
            switch (roverLocation.Direction)
            {
                case Direction.N:
                    roverLocation.Direction = Direction.E;
                    break;
                case Direction.E:
                    roverLocation.Direction = Direction.S;
                    break;
                case Direction.S:
                    roverLocation.Direction = Direction.W;
                    break;
                case Direction.W:
                    roverLocation.Direction = Direction.N;
                    break;
            }
        }

       
    }
}
