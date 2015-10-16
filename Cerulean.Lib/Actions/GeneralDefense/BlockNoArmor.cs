using Cerulean.Lib.Models.Data;
using Cerulean.Lib.Models.Units;

namespace Cerulean.Lib.Actions.GeneralDefense
{
    class BlockNoArmor : IDefenseAction
    {
        public DefenseInformation Defend(Unit defender)
        {
            return new DefenseInformation()
            {
                Defender = defender,
                DefenseModifier = 0
            };
        }
    }
}
