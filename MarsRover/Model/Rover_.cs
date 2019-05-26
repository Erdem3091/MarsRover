using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model
{
    public class Rover_
    {
        private int plateauRoverPositionX;
        private int plateauRoverPositionY;
        private String direction;
        private Plateau plateau;

        public int PlateauX
        {
            get { return plateauRoverPositionX; }
        }
        public int PlateauY
        {
            get { return plateauRoverPositionY; }
        }
        public String Direction
        {
            get { return direction; }
        }

        public Rover(Location location, Plateau plateau)
        {
            if (location.X >= 0 && location.Y >= 0 && location.X <= plateau.X && location.Y <= plateau.Y)
            {
                this.plateauRoverPositionX = x;
                this.plateauRoverPositionY = y;
            }
            else
            {
                //throw new OutOfBoundsException("Valores negativos não permitidos");
            }
            if (direction.Equals("N") || direction.Equals("S") ||
                direction.Equals("E") || direction.Equals("W"))
            {
                this.direction = direction;
            }
            else
            {
                //throw new InvalidStringValueException("String vazia ou inválida.");
            }
            this.plateau = plateau;
        }

        public String Process(String commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
            return direction;
        }

     
        public Location TurnLeft(Location current)
        {
           return Turn('L', current);
        }
        public Location TurnRight(Location current)
        {
            return Turn('R', current);
        }
        public Location Turn(char NextStep, Location current)
        {
            switch (current.Direction)
            {
                case "N":
                    current.Direction = (NextStep == 'R') ? "E" : "W";
                    break;
                case "S":
                    current.Direction = (NextStep == 'R') ? "W" : "E";
                    break;
                case "W":
                    current.Direction = (NextStep == 'R') ? "N" : "S";
                    break;
                case "E":
                    current.Direction = (NextStep == 'R') ? "S" : "N";
                    break;
            }

            return current;
        }
        public Location Move(Location current)
        {
            switch (current.Direction)
            {
                case "N":
                    current.Y += 1;
                    break;
                case "S":
                    current.Y -= 1;
                    break;
                case "W":
                    current.X -= 1;
                    break;
                case "E":
                    current.X += 1;
                    break;
            }
            return current;
        }

        public String toString()
        {
            return PlateauX + " " + PlateauY + " " + Direction;
        }
    }
}

