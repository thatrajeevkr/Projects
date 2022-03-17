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

        

    }
}