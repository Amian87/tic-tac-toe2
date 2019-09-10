using NUnit.Framework;
using System;
using TicTacToe;

namespace TicTacToeTests
{
    public class BoardTests
    {
        [Test]
        public void CreateEmptyBoard()
        {
            Board board = new Board();
            Tuple<int, string>[] expectedBoard = { };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);

        }

        [Test]
        public void MakeMove()
        {
            Board board = new Board();
            board.Move(2);
            Tuple<int, string>[] expectedBoard = { Tuple.Create(2, "X") };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);

        }

    }
}
