using System;

namespace CSharpStudying
{
    public class Orc : Monster
    {
        public override void UseSkill()
        {
            if (IsAbleSkill)
            {
                Skill();
            }
        }
        public Orc(int maxHp, int maxMp) : base(maxHp,maxMp)
        {
        }
        protected virtual void Skill()
        {
            Console.WriteLine("일반오크 스킬 발동!");
        }
        public override void Die()
        {
            Console.WriteLine("오크 죽음!");
        }
    }
    public class WizardOrc : Orc, IFly
    {
        public WizardOrc(int maxHp, int maxMp) : base(maxHp,maxMp)
        {
        }
        protected override void Skill()
        {
            Console.WriteLine("마법사 오크 스킬 발동!");
        }

        public void Fly()
        {
            Console.WriteLine("휘익~ 마법사 오크 난다!");
        }
    }
    public class KnightOrc : Orc
    {
        public KnightOrc(int maxHp, int maxMp) : base(maxHp,maxMp)
        {
        }
        protected override void Skill()
        {
            Console.WriteLine("전사오크 스킬 발동!");
        }
    }
    public class ArcherOrc : Orc
    {
        public ArcherOrc(int maxHp, int maxMp) : base(maxHp,maxMp)
        {
        }
        protected override void Skill()
        {
            Console.WriteLine("궁수오크 스킬 발동!");
        }
    }
}