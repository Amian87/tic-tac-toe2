using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IIO
    {
        string Read();

        void Write(string input);

    }
}
