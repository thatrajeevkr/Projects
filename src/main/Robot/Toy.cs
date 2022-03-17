using System;
using Game.Robot.Interface;
using Game.PlayBoard;
namespace Game.Robot
{
    public enum Command
    {
        PLACE_ROBOT,
        PLACE_WALL,
        MOVE,
        LEFT,
        RIGHT,
        REPORT
    }

    public class Toy : IToy
    {
        public Position Position { get; set; }
        public string Direction { get; set; }

        public void Place(Position position, string direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public Position GetNextPosition(int[,] wall)
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case "NORTH":
                    if(wall[newPosition.X,newPosition.Y+1]==1)
                    {
                        newPosition.Y = newPosition.Y + 2;
                    }
                    else
                    {
                        newPosition.Y = newPosition.Y + 1;
                    }
                    break;
                case "EAST":
                    if(wall[newPosition.X+1,newPosition.Y]==1)
                    newPosition.X = newPosition.X + 2;
                    else
                    {
                        newPosition.X = newPosition.X + 1;
                    }
                    break;
                case "SOUTH":
                    if(wall[newPosition.X,newPosition.Y-1]==1)
                    newPosition.Y = newPosition.Y - 2;
                    else
                    {
                        newPosition.Y = newPosition.Y - 1;
                    }
                    break;
                case "WEST":
                    if(wall[newPosition.X-1,newPosition.Y]==1)
                    newPosition.X = newPosition.X - 2;
                    else
                    {
                        newPosition.X = newPosition.X - 1;
                    }
                    break;
            }
            return newPosition;
        }

        public string GetNextDirection(string rotation)
        {
            string newDirection = "";
            switch (Direction)
            {
                case "NORTH":
                    if(rotation=="LEFT")
                    newDirection = "WEST";
                    else newDirection="EAST";
                    break;
                case "EAST":
                    if(rotation=="LEFT")
                    newDirection = "NORTH";
                    else newDirection="SOUTH";
                    break;
                case "SOUTH":
                    if(rotation=="LEFT")
                    newDirection = "EAST";
                    else newDirection="WEST";
                    break;
                case "WEST":
                    if(rotation=="LEFT")
                    newDirection = "SOUTH";
                    else newDirection="NORTH";
                    break;
            }
            return newDirection;
        }
        

    }
}