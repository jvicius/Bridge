using Bridge.Implementation;
using System;

namespace Bridge.Abstraction
{
    public class Circle : Shape
    {
        public override void DrawShape()
        {
            double radius = 5;
            double thickness = 0.4;
            Console.ForegroundColor = BridgeColor.SetColor();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
