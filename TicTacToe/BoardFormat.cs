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
            if (HasXSymbolAtLocation(2))
            {
                return "[_,X,_,_,_,_,_,_,_]";
            }
            else if(HasXSymbolAtLocation(1))
            {
                return "[X,_,_,_,_,_,_,_,_]";
            }
            else
            {
                return "[_,_,_,_,_,_,_,_,_]";
            }
        }

        private bool HasXSymbolAtLocation(int location)
        {
            return board.CurrentMarks().Contains(Tuple.Create(location, "X"));
        }

    }
}
