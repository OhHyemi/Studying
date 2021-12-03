namespace CSharpStudying
{
    public abstract class Monster
    {
        private int maxHp;
        private int maxMp;
        private int hp;
        private int mp;

        private bool isAbleSkill;
        public bool IsAbleSkill
        {
            get => mp > 0;
            private set => isAbleSkill = value;
        }

        private bool IsAlive=> hp > 0;
        public int Hp
        {
            get => hp;
            set
            {
                var _hp = hp + value;
                if (_hp > maxHp)
                {
                    hp = maxHp;
                }
                else if (_hp <= 0)
                {
                    Die();
                }
                else
                {
                    hp = _hp;
                }
            }
        }
        public int Mp
        {
            get => mp;
            set
            {
                var _mp = mp + value;
                if (_mp > maxMp)
                {
                    mp = maxMp;
                }
                else if (_mp <= 0)
                {
                    mp = 0;
                }
                else
                {
                    mp = _mp;
                }
            }
        }

        protected Monster(int maxHp, int maxMp)
        {
            this.maxHp = maxHp;
            this.maxMp = maxMp;
            hp = maxHp;
            mp = maxMp;
        }
        public abstract void UseSkill();
        public abstract void Die();
        public void SetEnableUseSkill(bool able)
        {
            isAbleSkill = able;
        }
    }
}