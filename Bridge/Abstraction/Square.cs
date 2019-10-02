using System;

namespace Bridge.Abstraction
{
    public class Square : Shape
    {
        public override void DrawShape()
        {
            Console.ForegroundColor = BridgeColor.SetColor();
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");
        }
    }
}
