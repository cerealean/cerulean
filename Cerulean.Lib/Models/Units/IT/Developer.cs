using System;
using Cerulean.Lib.Actions.General;
using Cerulean.Lib.Actions.GeneralDefense;
using Cerulean.Lib.Models.Data;

namespace Cerulean.Lib.Models.Units.IT
{
    class Developer : Unit
    {
        public Developer()
        {
            Health = 100;
            AttackPower = 5;
            AttackAction = new MeleeAttack();
            DefenseAction = new BlockNoArmor();
        }

        public override AttackInformation PerformAttack()
        {
            return AttackAction.Attack(this);
        }

        public override DefenseInformation PerformDefense()
        {
            return DefenseAction.Defend(this);
        }
    }
}
