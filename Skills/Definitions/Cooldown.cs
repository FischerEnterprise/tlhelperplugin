using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class Cooldown : CastDefinition {
        public override bool CanCast(IPlayerSkill skill, IController hud) {
            return !skill.IsOnCooldown;
        }
     }

}