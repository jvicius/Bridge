using System;

namespace Bridge.Implementation
{
    public class Red : IColor
    {
        public ConsoleColor SetColor()
        {
            return ConsoleColor.Red;
        }
    }
}