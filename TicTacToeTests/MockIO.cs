using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe;

namespace TicTacToeTests
{
    public class MockIO : IIO
    {
        public string Read()
        {
            return "";
        }

        public void Write(string input) {}
    }
}
