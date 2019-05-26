using MarsRover.Enums;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Command
{
    public class MoveCommand : ICommand
    {
       public void Execute (Location roverLocation)
        {
            switch (roverLocation.Direction)
            {
                case Direction.N:
                    roverLocation.Y += 1;
                    break;
                case Direction.E:
                    roverLocation.X += 1;
                    break;
                case Direction.S:
                    roverLocation.Y -= 1;
                    break;
                case Direction.W:
                    roverLocation.X -= 1;
                    break;
            }

        }

       
    }
}
