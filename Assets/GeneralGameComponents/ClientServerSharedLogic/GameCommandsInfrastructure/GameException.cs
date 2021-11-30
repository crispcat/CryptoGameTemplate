using System;

namespace Game
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