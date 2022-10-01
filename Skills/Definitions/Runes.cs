using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class Runes : CastDefinition {

        private string[] runes;

        public Runes(params string[] runes) {
            this.runes = runes;
        }

        public override bool CanCast(IPlayerSkill skill, IController hud) {
            foreach (string rune in runes)
            {
                if (skill.RuneNameEnglish == rune) return true;
            }
            return false;
        }
     }

}