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

        public Position GetNextPosition()
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case "NORTH":
                    newPosition.Y = newPosition.Y + 1;
                    break;
                case "EAST":
                    newPosition.X = newPosition.X + 1;
                    break;
                case "SOUTH":
                    newPosition.Y = newPosition.Y - 1;
                    break;
                case "WEST":
                    newPosition.X = newPosition.X - 1;
                    break;
            }
            return newPosition;
        }
        

    }
}