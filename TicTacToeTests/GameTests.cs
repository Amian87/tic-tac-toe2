using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe;

namespace TicTacToeTests
{
    class GameTests
    {
        [Test]
        public void PlayerOneCanMakeAMoveInANewGame()
        {
            Game game = new Game();
            game.Move(3);
            Tuple<int, string>[] currentMarks = {Tuple.Create(3, "X")};
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void PlayerTwoCanMakeAMoveInAGame()
        {
            Game game = new Game();
            game.Move(3);
            game.Move(1);
            Tuple<int, string>[] currentMarks = {Tuple.Create(3, "X"), Tuple.Create(1, "O")};
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void ThreeMovesInARow()
        {
            Game game = new Game();
            game.Move(2);
            game.Move(4);
            game.Move(6);
            Tuple<int, string>[] currentMarks = {Tuple.Create(2, "X"), Tuple.Create(4, "O"), Tuple.Create(6, "X")};
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void AGameCanHaveAWinnerOfX()
        {
            Game game = new Game();
            game.Move(1);
            game.Move(2);
            game.Move(3);
            game.Move(4);
            game.Move(5);
            game.Move(6);
            game.Move(7);
            Assert.AreEqual(game.Status(), "X");
        }

        [Test]
        public void AGameStartsOffInProgress()
        {
            Game game = new Game();
            Assert.AreEqual(game.Status(), "In Progress");
        }

        [Test]
        public void AGameCanEndInADraw()
        {
            Game game = new Game();
            game.Move(1);
            game.Move(2);
            game.Move(3);
            game.Move(4);
            game.Move(6);
            game.Move(5);
            game.Move(7);
            game.Move(9);
            game.Move(8);
            Assert.AreEqual(game.Status(), "Draw");
        }

        [Test]
        public void AGameCanHaveAWinnerOfO()
        {
            Game game = new Game();
            game.Move(1);
            game.Move(4);
            game.Move(2);
            game.Move(5);
            game.Move(7);
            game.Move(6);
            Assert.AreEqual(game.Status(), "O");
        }

        [Test]
        public void XWinsInTopRow()
        {
            Game game = new Game();
            game.Move(1);
            game.Move(4);
            game.Move(2);
            game.Move(5);
            game.Move(3);
            Assert.AreEqual(game.Status(), "X");
        }

        [Test]
        public void XWinsMiddleRow()
        {
            Game game = new Game();
            game.Move(4);
            game.Move(1);
            game.Move(5);
            game.Move(7);
            game.Move(6);
            Assert.AreEqual(game.Status(), "X");
        }

        [Test]
        public void XWinsBottomRow()
        {
            Game game = new Game();
            game.Move(7);
            game.Move(1);
            game.Move(8);
            game.Move(7);
            game.Move(9);
            Assert.AreEqual(game.Status(), "X");
        }
    }
}
