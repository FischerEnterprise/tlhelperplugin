using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class Resource : CastDefinition {
        public override bool CanCast(IPlayerSkill skill, IController hud) {
            var resourceCostType = skill.SnoPower.ResourceCostTypeByRune[skill.Rune == 255 ? 0 : skill.Rune];
            var currentResource = resourceCostType == PowerResourceCostType.primary
                ? hud.Game.Me.Stats.ResourceCurPri
                : hud.Game.Me.Stats.ResourceCurSec;

            return (currentResource >= skill.GetResourceRequirement(skill.ResourceCost));
        }
     }

}