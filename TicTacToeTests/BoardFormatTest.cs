using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe;

namespace TicTacToeTests
{
    class BoardFormatTest
    {        
        [Test]
        public void ItConvertsAnEmptyBoardToAString()
        {
            Board board = new Board();
            BoardFormat boardFormat = new BoardFormat(board);
            Assert.AreEqual(boardFormat.Convert(), "[_,_,_,_,_,_,_,_,_]");
        }

        [Test]
        public void ItMovesInSpotOne()
        {
            Board board = new Board();
            BoardFormat boardFormat = new BoardFormat(board);
            board.Move(1, "X");
            Assert.AreEqual(boardFormat.Convert(), "[X,_,_,_,_,_,_,_,_]");
        }

        [Test]
        public void ItMovesInSpotTwo()
        {
            Board board = new Board();
            BoardFormat boardFormat = new BoardFormat(board);
            board.Move(2, "X");
            Assert.AreEqual(boardFormat.Convert(), "[_,X,_,_,_,_,_,_,_]");
        }
    }
}
