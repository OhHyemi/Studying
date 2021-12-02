namespace CSharpStudying
{
    public abstract class Animal
    {
        private bool isAlive = true;

        public abstract void Eat();

        public virtual void Die()
        {
            isAlive = false;
        }
    }
}