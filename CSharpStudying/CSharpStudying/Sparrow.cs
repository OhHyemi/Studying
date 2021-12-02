using System;

namespace CSharpStudying
{
    public class Sparrow : Birds, IFly
    {
        public void Fly()
        {
            Console.WriteLine("포로록~ 참새 난다~");
        }

        public Sparrow(Beak beak) : base(beak)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("참새 쌀알 먹는다. 콕콕!");
        }
    }
}