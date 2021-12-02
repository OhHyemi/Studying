using System.Drawing;

namespace CSharpStudying
{
    public class Beak
    {
        public float Length { get; private set; }
        public Color Color { get; private set; }

        public Beak(float length, Color color)
        {
            this.Length = length;
            this.Color = color;
        }
    }
    public abstract class Birds : Animal
    {
        protected Birds(Beak beak)
        {
            this.beak = beak;
        }
        public Beak beak { get; private set; }
    }
}