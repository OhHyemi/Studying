using System;

namespace CSharpStudying
{
    public class Penguin : Birds, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("슈슉~ 펭귄 수영한다~");
        }

        public Penguin(Beak beak) : base(beak)
        {
        }
    }
}