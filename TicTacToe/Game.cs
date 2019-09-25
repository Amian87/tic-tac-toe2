using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private Board board = new Board();
        private String currentMark = "X";

        public List<Tuple<int, string>> CurrentMarks()
        {
            return board.CurrentMarks();
        }

        public void Move(int position)
        {
            board.Move(position, currentMark);
            if(currentMark == "X")
            {
                currentMark = "O";
            }
            else
            {
                currentMark = "X";
            }
        }

        public string Status()
        {
            if (isDraw())
            {
                return "Draw";
            }
            else if (playerOWins())
            {
                return "O";
            }
            else if (playerXWins())
            {
                return "X";
            }
            else
            {
                return "In Progress";
            }
        }

        private bool playerOWins() 
        {
            return board.CurrentMarks().Count == 6;
        }

        private bool playerXWins()
        {
            if (board.CurrentMarks().Contains(Tuple.Create(1, "X")) && board.CurrentMarks().Contains(Tuple.Create(2, "X")) && board.CurrentMarks().Contains(Tuple.Create(3, "X")))
            {
                return true;
            }
            else if(board.CurrentMarks().Contains(Tuple.Create(4, "X")) && board.CurrentMarks().Contains(Tuple.Create(5, "X")) && board.CurrentMarks().Contains(Tuple.Create(6, "X")))
            {
                return true;
            }
            else if (board.CurrentMarks().Contains(Tuple.Create(7, "X")) && board.CurrentMarks().Contains(Tuple.Create(8, "X")) && board.CurrentMarks().Contains(Tuple.Create(9, "X")))
            {
                return true;
            }


            return board.CurrentMarks().Count >= 7;
        }

        private bool isDraw()
        {
            return board.CurrentMarks().Count == 9;
        }
    }
}
