using System;

namespace Bridge.Implementation
{
    public class Blue : IColor
    {
        public ConsoleColor SetColor()
        {
            return ConsoleColor.Blue;
        }
    }
}