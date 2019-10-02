using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Abstraction;
using Bridge.Implementation;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           Shape shape;
            
           shape = new Circle();
           shape.BridgeColor = new Blue();
           shape.DrawShape(); 

           shape = new Square();
           shape.BridgeColor = new Red();
           shape.DrawShape();

           Console.ReadKey();
        }
    }
}
