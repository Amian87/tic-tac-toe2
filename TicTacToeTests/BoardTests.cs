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
        public void MakeOneMove()
        {
            Board board = new Board();
            board.Move(2, "X");
            Tuple<int, string>[] expectedBoard = { Tuple.Create(2, "X") };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);

        }

        [Test]
        public void MakeTwoMoves()
        {
            Board board = new Board();
            board.Move(1, "X");
            board.Move(3, "O");
            Tuple<int, string>[] expectedBoard = { Tuple.Create(1, "X"), Tuple.Create(3, "O") };

        }



    }
}
