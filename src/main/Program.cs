using System;
using Game.PlayBoard;
using Game.PlayBoard.Interface;
namespace ToyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayBoard squareBoard = new PlayBoard(5, 5);
            string command = Console.ReadLine();
            Console.WriteLine(command);
        }
    }
}