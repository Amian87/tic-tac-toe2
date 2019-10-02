using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class BoardFormat
    {
        private Board board;

        public BoardFormat(Board b) {
            board = b;
        }

        public string Convert()
        {
            List<string> boardToDisplay = emptyBoard();

            foreach (Tuple<int,string> mark in board.CurrentMarks())
            {

                return AddMarkToBoard(boardToDisplay, mark.Item1, mark.Item2);

                //return FormattedBoardWithOneSymbol(mark.Item1, mark.Item2);
            }
           
            return "[" + string.Join(",", boardToDisplay.ToArray()) + "]";
        }

        private List<string> emptyBoard()
        {
            List<string> emptyBoard = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                emptyBoard.Add("_");
            }
            return emptyBoard;
        }

        private void AddMarkToBoard(List<string> currentBoard, int location, string symbol)
        {
          
                currentBoard.Insert(location, symbol);

        }


        private string FormattedBoardWithOneSymbol(int location, string symbol)
        {
            if(location == 1)
            {
                return "[" + symbol + ",_,_,_,_,_,_,_,_]";
            }
            else if(location == 2)
            {
                return "[_," + symbol + ",_,_,_,_,_,_,_]";
            }
            else if(location == 3)
            {
                return "[_,_," + symbol + ",_,_,_,_,_,_]";
            }
            else 
            {
                return "[_,_,_,_,_,_,_," + symbol + ",_]";
            }
            
        }

    }
}
