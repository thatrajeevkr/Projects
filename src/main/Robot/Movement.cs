using System;
using Game.Robot.Interface;
using Game.PlayBoard;
using Game.PlayBoard.Interface;
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
                switch(args[0])
                {
                    case "PLACE_ROBOT":
                        string[] inputs = args[1].Split(',');
                        if(playBoard.IsValidPosition(new Position(Convert.ToInt32(inputs[0]),Convert.ToInt32(inputs[1]))))
                        Toy.Place(new Position(Convert.ToInt32(inputs[0]),Convert.ToInt32(inputs[1])), inputs[2]);
                        break;
                    case "PLACE_WALL":
                        
                        break;
                    case "MOVE": 
                        var newPosition = Toy.GetNextPosition();
                        if(playBoard.IsValidPosition(newPosition))
                        Toy.Place(newPosition, Toy.Direction);
                        else if(newPosition.X>5)
                        Toy.Place(new Position(1,newPosition.Y), Toy.Direction);
                        else if(newPosition.Y>5)
                        Toy.Place(new Position(newPosition.X,1), Toy.Direction);
                        else if(newPosition.X<=0)
                        Toy.Place(new Position(5,newPosition.Y), Toy.Direction);
                        else if(newPosition.Y<=0)
                        Toy.Place(new Position(newPosition.X,5), Toy.Direction);
                        break;
                    case "REPORT": 
                        Console.WriteLine("{0},{1},{2}", Toy.Position.X,
                        Toy.Position.Y, Toy.Direction);
                        break;
                    case "LEFT": break;
                    case "RIGHT": break;

                }
            }          
            

        }
    }
}