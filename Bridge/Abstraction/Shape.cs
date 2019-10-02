using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public abstract class Shape
    {
        public IColor BridgeColor;

        public abstract void DrawShape();
    }
}
