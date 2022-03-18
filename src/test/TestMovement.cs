using NUnit.Framework;
using Game.PlayBoard;
using Game.PlayBoard.Interface;
using Game.Robot;
using Game.Robot.Interface;

namespace Game.Test
{
    [TestFixture]
    public class TestMovement
    {
        /// <summary>
        /// Testing Valid RobotPlace command
        /// </summary>
        [Test]
        public void TestValidRobotPlace()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            Assert.AreEqual(3, toy.Position.X);
            Assert.AreEqual(3, toy.Position.Y);
            Assert.AreEqual("NORTH", toy.Direction);
        }

        [Test]
        public void TestInValidRobotPlace()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            Assert.IsNull(toy.Position);
        }

        [Test]
        public void TestValidRobotMove()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            movement.InCommand("MOVE".Split(' '));
            Assert.AreEqual(3, toy.Position.X);
            Assert.AreEqual(4, toy.Position.Y);
            Assert.AreEqual("NORTH", toy.Direction);
        }

        [Test]
        public void TestValidRobotLeft()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            movement.InCommand("MOVE".Split(' '));
            movement.InCommand("LEFT".Split(' '));
            Assert.AreEqual("WEST", toy.Direction);
        }

        [Test]
        public void TestValidRobotRight()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            movement.InCommand("MOVE".Split(' '));
            movement.InCommand("RIGHT".Split(' '));
            Assert.AreEqual("EAST", toy.Direction);
        }

        public void TestInValidRobotRight()
        {
            IPlayBoard squareBoard = new PlayBoards(5, 5);
            Toy toy = new Toy();
            Movement movement = new Movement(toy, squareBoard);
            movement.InCommand("PLACE_ROBOT 3,3,NORTH".Split(' '));
            movement.InCommand("MOVE".Split(' '));
            movement.InCommand("RIGHT".Split(' '));
            Assert.AreEqual("SOUTH", toy.Direction);
        }
    }
}