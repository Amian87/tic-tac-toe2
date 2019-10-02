using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private List<Tuple<int, string>> Marks = new List<Tuple<int, string>>();

        public List<Tuple<int, string>> CurrentMarks()
        {
            return Marks;
        }

        public void Move(int position, string symbol)
        {
            Marks.Add(Tuple.Create(position, symbol));
        }


    }
}
