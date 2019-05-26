using MarsRover.Enums;
using MarsRover.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Model
{
    public class Rover
    {
        public Location Location;
        public Plateau Plateau;
       

        public Rover(int x, int y, String direction, Plateau plateau)
        {
            Location = new Location();
           
            //Geçersiz direction kontrolu
            if (Enum.TryParse<Direction>(direction, false, out Direction currentDirection))
            {
                Location.Direction = currentDirection;
            }
            else
            {
                throw new InvalidOperationException("Invalid Direction");
            }

            //Rover posizyonu plateaunın içinde mi kontrolu
            if (x >= 0 && y >= 0 && x <= plateau.X && y <= plateau.Y)
            {
                Location.X = x;
                Location.Y = y;
            }
            else
            {
                throw new InvalidOperationException("Rover position is out of plateau");
            }


            Plateau = plateau;
        }

        public void ReadCommands(String commands)
        {
            foreach (char character in commands)
            {
                switch (character)
                {
                    case 'L':
                        TurnLeftCommand turnLeftCommand = new TurnLeftCommand();
                        turnLeftCommand.Execute(Location);
                        break;
                    case 'R':
                        TurnRightCommand turnRightCommand = new TurnRightCommand();
                        turnRightCommand.Execute(Location);
                        break;
                    case 'M':
                        if (RoverCanMove())
                        {
                            MoveCommand moveCommand = new MoveCommand();
                            moveCommand.Execute(Location);
                        }
                        else
                        {
                            throw new InvalidOperationException("Rover Can't Move Because of Plateau Border");
                        }
                        break;
                        
                }
            }
        }

        //Rover ilerlemesi durumunda plateaudan çıkıyor mu kontrolu
        public bool RoverCanMove()
        {
            switch (Location.Direction)
            {
                case Direction.N:
                    return (Location.Y < Plateau.Y);
                case Direction.E:
                    return (Location.X < Plateau.X);
                case Direction.S:
                    return (Location.Y > 0);
                case Direction.W:
                    return (Location.X > 0);
                default:
                    return false;
            }
           
        }

        public string GetCurrentLocation()
        {
            return Location.X + " " + Location.Y + " " + Location.Direction;
        }
    }
}
