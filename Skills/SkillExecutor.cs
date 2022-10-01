using System;
using System.Collections.Generic;
using System.Linq;

using Turbo.Plugins.TL.Helper.Skills.Definitions;
using Turbo.Plugins.TL.Helper.Skills.DefinitionGroups;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.UI;

namespace Turbo.Plugins.TL.Helper.Skills {

    public class SkillExecutor {

        private readonly Dictionary<uint, long> lastExecution = new Dictionary<uint, long>();
        private readonly Dictionary<uint, List<CastDefinitionGroup>> castDefinitions = new Dictionary<uint, List<CastDefinitionGroup>>();

        private const long MINIMUM_CAST_DELTA = 50;

        private bool CheckSkillActive(ActionKey key) {
            if ((int)key > (int)ActionKey.Skill4) return false;

            var settings = MainWindow.GetInstance().Settings;

            // lmb
            if (key == ActionKey.LeftSkill) return settings["skill_lmb"] == "enabled";

            // rmb
            if (key == ActionKey.RightSkill) return settings["skill_rmb"] == "enabled";

            // buttons (1-4)
            else return settings[String.Format("skill_{0}", (((int) key) - 1).ToString())] == "enabled";
        }

        public void Cast(IPlayerSkill skill, IController hud) {
            if (!CheckSkillActive(skill.Key)) return; // check if skill is active
            if (!checkExecutionTiming(skill)) return; // check if skill can be casted again

            
            if (!castDefinitions.ContainsKey(skill.SnoPower.Sno)) { // check if definition for skill exists
                if (!new Cooldown().CanCast(skill, hud)) return;
                if (!new Resource().CanCast(skill, hud)) return;
            }
            else {
                // get first aplicable definition group
                CastDefinitionGroup aplicableGroup = castDefinitions[skill.SnoPower.Sno].FirstOrDefault(definitionGroup => definitionGroup.Aplicable(skill, hud));

                // cancel if no group is aplicable
                if (aplicableGroup == null) return;

                // check if all definitions in group are satisfied
                if (!aplicableGroup.Satisfied(skill, hud)) return;
            }

            // cast skill
            skill.Cast();

            // update lastExecution
            lastExecution[skill.SnoPower.Sno] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public void RegisterDefinitionGroup(uint sno, CastDefinitionGroup definition) {
            if (!castDefinitions.ContainsKey(sno))
                castDefinitions.Add(sno, new List<CastDefinitionGroup>());

            castDefinitions[sno].Add(definition);
        }

        private bool checkExecutionTiming(IPlayerSkill skill) {
            var sno = skill.SnoPower.Sno;
            var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            if (!lastExecution.ContainsKey(sno))
            {
                lastExecution.Add(sno, now);
                return true;
            }

            var lastExecutionTime = lastExecution[sno];
            return now - lastExecutionTime >= MINIMUM_CAST_DELTA;
        }

    }

}