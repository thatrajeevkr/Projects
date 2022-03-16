using System;

namespace Game.PlayBoard.Interface
{
    public interface IPlayBoard
    {
        //Returns True or False if position entered is valid in Board
        bool IsValidPosition(Position position);
    }
}
