﻿using System;
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
            else if (playerWins("O"))
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

        private bool playerWins(string symbol) 
        {
            foreach(Tuple<int,int,int> combination in winningCombinations())
            {
                if (threeInARow(symbol, combination)) return true;
            }
            return false;
        }

        private bool playerXWins()
        {
            foreach(Tuple<int,int,int> combination in winningCombinations())
            {
                bool result = threeInARow("X", combination);
                if (result == true)
                    return true;
                
            }
            //return false;

            return threeInARow("X", 2,5,8) || threeInARow("X", 3,6,9) || threeInARow("X", 1,5,9) || threeInARow("X", 3,5,7);
        }

        private List<Tuple<int,int,int>> winningCombinations()
        {
            Tuple<int,int,int>[] combinations = {Tuple.Create(1,2,3), Tuple.Create(4,5,6), Tuple.Create(7, 8, 9), Tuple.Create(1,4,7)};
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
