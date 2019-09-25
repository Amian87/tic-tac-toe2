using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class IO : IIO
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}
