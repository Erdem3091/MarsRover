using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Model;

namespace MarsRover.Command
{
    public interface ICommand
    {
        void Execute(Location roverLocation);
    }
}
