using System;

namespace CSharpStudying
{
    public class SugarGlider : Mammalia, IFly
    {
        public void Fly()
        {
            Console.WriteLine("슝~ 슈가 글라이더 난다~");
        }
    }
}