using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Plateau(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                X = x;
                Y = y;
            }
            else
            {
                throw new InvalidOperationException("Invalid Plateau Coordinate");
            }
        }
    }
}
