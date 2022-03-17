using System;
using Game.PlayBoard;
using Game.PlayBoard.Interface;
using Game.Robot;
using Game.Robot.Interface;
namespace ToyGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IPlayBoard squareBoard = new PlayBoard(5, 5);
            IToy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            var stopApp = false;
            Console.WriteLine("Enter Input");
            do
            {   
                string command = Console.ReadLine();
                if (command.Equals("EXIT"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    movement.InCommand(command.Split(' '));
                }
            }while(!stopApp);
        }
    }
}