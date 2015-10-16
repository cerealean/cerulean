namespace Cerulean.Lib.Units
{
    public abstract class Unit
    {
        public int Health { get; private set; }
        public int Armor { get; private set; }
        public int AttackPower { get; private set; }

        public abstract void Attack();
        public abstract void TakeDamage();
    }
}
