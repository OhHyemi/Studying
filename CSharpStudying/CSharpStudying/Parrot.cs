using System;

namespace CSharpStudying
{
    public class Parrot : Birds, IFly
    {
        public void Fly()
        {
           Console.WriteLine("푸드덕~ 앵무새 난다~");
        }

        public Parrot(Beak beak) : base(beak)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("츄릅~ 앵무새 메뚜기 먹는다!");
        }
    }
}