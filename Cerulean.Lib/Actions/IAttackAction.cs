using Cerulean.Lib.Models.Data;
using Cerulean.Lib.Models.Units;

namespace Cerulean.Lib.Actions
{
    public interface IAttackAction
    {
        AttackInformation Attack(Unit attacker);
    }
}
