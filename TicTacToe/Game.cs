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
            return board.CurrentMarks().Contains(Tuple.Create(1, "O"))
            && board.CurrentMarks().Contains(Tuple.Create(2, "O"))
            && board.CurrentMarks().Contains(Tuple.Create(3, "O"));
        }

        private bool playerXWins()
        {
            return threeInARow("X", 1,2,3) || threeInARow("X", 4,5,6) || threeInARow("X", 7,8,9) || threeInARow("X", 1,4,7) || threeInARow("X", 2,5,8) || threeInARow("X", 3,6,9) || threeInARow("X", 1,5,9) || threeInARow("X", 3,5,7);
        }

        private List<Tuple<int,int,int>> winningCombinations() 
        {
            Tuple<int,int,int>[] combinations = {};
            return new List<Tuple<int,int,int>>(combinations);
        }

        private bool threeInARow(string symbol, Tuple<int,int,int> winningCombination)
        {
            return board.CurrentMarks().Contains(Tuple.Create(winningCombination.Item1, symbol))
            && board.CurrentMarks().Contains(Tuple.Create(winningCombination.Item2, symbol))
            && board.CurrentMarks().Contains(Tuple.Create(winningCombination.Item3, symbol));
        }

        private bool threeInARow(string symbol, int positionOne, int positionTwo, int positionThree)
        {
            return board.CurrentMarks().Contains(Tuple.Create(positionOne, symbol))
            && board.CurrentMarks().Contains(Tuple.Create(positionTwo, symbol))
            && board.CurrentMarks().Contains(Tuple.Create(positionThree, symbol));
        }

        private bool isDraw()
        {
            return board.CurrentMarks().Count == 9;
        }
    }
}
