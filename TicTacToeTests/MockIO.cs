using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe;

namespace TicTacToeTests
{
    public class MockIO : IIO
    {
        public bool writeWasCalled = false;
        public string inputThatWasGivenToWrite = "";

        public string Read()
        {
            return "5";
        }

        public void Write(string input)
        {
            writeWasCalled = true;
            inputThatWasGivenToWrite = input;
        }
    }
}
