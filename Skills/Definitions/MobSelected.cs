using System.Linq;

using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class MobSelected : CastDefinition {

        private bool elite;

        public MobSelected(bool elite = false) {
            this.elite = elite;
        }

        public override bool CanCast(IPlayerSkill skill, IController hud) {
            if (hud.Game.SelectedMonster2 == null) return false;
            return ((!elite) || hud.Game.SelectedMonster2.IsElite);
        }
     }

}