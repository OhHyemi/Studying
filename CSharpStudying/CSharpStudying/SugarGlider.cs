using System;

namespace CSharpStudying
{
    public class SugarGlider : Mammalia, IFly
    {
        public void Fly()
        {
            Console.WriteLine("슝~ 슈가 글라이더 난다~");
        }

        public override void Eat()
        {
            Console.WriteLine("호로롭~~ 슈가글라이더 사료먹는다.");
        }
    }
}