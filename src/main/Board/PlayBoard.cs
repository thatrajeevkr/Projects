using Game.PlayBoard.Interface;

namespace Game.PlayBoard
{
    /// <summary>
    /// Main Playing Board with Rows and Columns as Properties, Along with check function
    /// </summary>
    public class PlayBoard : IPlayBoard
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public PlayBoard(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
        }

        //Check if position entered is valid
        public bool IsValidPosition(Position position)
        {
            return position.X <= Columns && position.X >= 1 && 
                   position.Y <= Rows && position.Y >= 1 && position.Wallcheck==false;
        }
    }
}
