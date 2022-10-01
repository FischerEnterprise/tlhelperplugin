using System.Collections.Generic;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Skills.Definitions;

namespace Turbo.Plugins.TL.Helper.Skills.DefinitionGroups {

    public delegate bool AplicableCheck(IPlayerSkill skill, IController hud);

    public class CastDefinitionGroup {

        public CastDefinitionGroup(SkillExecutor executor, uint sno) {
            CustomAplicable = (s, h) => true;
            executor.RegisterDefinitionGroup(sno, this);
        }

        public AplicableCheck CustomAplicable;
        public List<CastDefinition> CastDefinitions = new List<CastDefinition>();
        public List<CastDefinition> AplicableDefinitions = new List<CastDefinition>();
        public bool Satisfied(IPlayerSkill skill, IController hud) {
            return CastDefinitions.TrueForAll(definition => definition.Satisfied(skill, hud));
        }

        public bool Aplicable(IPlayerSkill skill, IController hud) {
            return this.CustomAplicable(skill, hud) && AplicableDefinitions.TrueForAll(definition => definition.Satisfied(skill, hud));
        }

    }

}