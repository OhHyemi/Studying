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
        private int num;

        protected Birds(Beak beak)
        {
            this.beak = beak;
        }

        public int Num
        {
            get
            {
                return num;
            }
            set { num = value < 0 ? 0 : value; }
        }
        public Beak beak { get; private set; }
       
        
    }
}