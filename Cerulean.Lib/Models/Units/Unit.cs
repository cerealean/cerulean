using Cerulean.Lib.Actions;
using Cerulean.Lib.Models.Data;

namespace Cerulean.Lib.Models.Units
{
    public abstract class Unit
    {
        protected int Health;
        protected int NaturalArmor = 0;
        protected int AttackPower = 1;
        protected int Level = 1;
        protected IAttackAction AttackAction;
        protected IDefenseAction DefenseAction;

        public abstract AttackInformation PerformAttack();
        public abstract DefenseInformation PerformDefense();

        public void SubtractHealth(int healthLossAmount)
        {
            Health = (healthLossAmount > Health) ? 0 : Health - healthLossAmount;
        }
    }
}
