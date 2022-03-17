using System;
using Game.Robot.Interface;
using Game.PlayBoard;
using Game.PlayBoard.Interface;\
using ToyGame;
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
            Command command;
            if (!Enum.TryParse(args[0], true, out command))
                throw new ArgumentException("Invalid Command");
            else
            {
                string[] inputs = args[1].Split(',');
                switch(args[0])
                {
                    case "PLACE_ROBOT":
                        if(playBoard.IsValidPosition(new Position(Convert.ToInt32(inputs[0]),Convert.ToInt32(inputs[1]))))
                        Toy.Place(new Position(Convert.ToInt32(inputs[0]),Convert.ToInt32(inputs[1])), inputs[2]);
                        break;
                    case "PLACE_WALL": break;
                    case "MOVE": break;
                    case "REPORT": break;
                    case "LEFT": break;
                    case "RIGHT": break;

                }
            }          
            

        }
    }
}