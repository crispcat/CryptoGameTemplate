using System;

namespace CGT
{
    public class GameException : Exception
    {
        public GameException(string message) : base(message)
        {
        }
        public GameException() 
        {
        }
    }
}