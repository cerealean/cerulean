using Cerulean.Lib.Models.Data;
using Cerulean.Lib.Models.Units;

namespace Cerulean.Lib.Actions.General
{
    class MeleeAttack : IAttackAction
    {
        public AttackInformation Attack(Unit attacker)
        {
            return new AttackInformation()
            {
                Attacker = attacker,
                Range = 1,
                Trample = false
            };
        }
    }
}
