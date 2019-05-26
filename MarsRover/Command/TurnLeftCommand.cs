using MarsRover.Enums;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Command
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute (Location roverLocation)
        {
            switch (roverLocation.Direction)
            {
                case Direction.N:
                    roverLocation.Direction = Direction.W;
                    break;
                case Direction.E:
                    roverLocation.Direction = Direction.N;
                    break;
                case Direction.S:
                    roverLocation.Direction = Direction.E;
                    break;
                case Direction.W:
                    roverLocation.Direction = Direction.S;
                    break;
            }
        }

       
    }
}
