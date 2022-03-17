using System;
using Game.Robot.Interface;
using Game.PlayBoard;
using Game.PlayBoard.Interface;
namespace Game.Robot
{
    public class Movement
    {
        public IToy Toy {get;set;}
        public IPlayBoard playBoard {get;set;}
        public Movement(IToy toy,IPlayBoard playboard)
        {
            Toy=toy;
            playBoard=playboard;
        }
        public void InCommand(string[] args)
        {
            

        }
    }
}