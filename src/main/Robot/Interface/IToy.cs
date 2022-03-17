using Game.PlayBoard;
namespace Game.Robot.Interface
{
    public interface IToy
    {
        public Position Position { get; set; }
        public string Direction { get; set; }
        void Place(Position position, string direction);
    }
}