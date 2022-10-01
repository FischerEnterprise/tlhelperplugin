using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class ResourceAbove : CastDefinition {

        private float minResourcePct;

        public ResourceAbove(float minResourcePct) {
            this.minResourcePct = minResourcePct;
        }

        public override bool CanCast(IPlayerSkill skill, IController hud) {
            var resourceCostType = skill.SnoPower.ResourceCostTypeByRune[skill.Rune == 255 ? 0 : skill.Rune];
            var currentResourcePct = resourceCostType == PowerResourceCostType.primary
                ? hud.Game.Me.Stats.ResourcePctPri
                : hud.Game.Me.Stats.ResourcePctSec;

            return (currentResourcePct >= minResourcePct);
        }
     }

}