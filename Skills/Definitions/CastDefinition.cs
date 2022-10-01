namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public abstract class CastDefinition {
        private bool Inverted = false;
        public abstract bool CanCast(IPlayerSkill skill, IController hud);
        public bool Satisfied(IPlayerSkill skill, IController hud) {
            if (Inverted)
                return !CanCast(skill, hud);
            return CanCast(skill, hud);
        }

        public void Invert() {
            this.Inverted = true;
        }
     }

}