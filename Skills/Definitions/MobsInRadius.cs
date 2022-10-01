using System.Linq;

using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class MobsInRadius : CastDefinition {

        private int radius;
        private int minAmount;

        public MobsInRadius(int radius, int minAmount = 1) {
            this.radius = radius;
            this.minAmount = minAmount;
        }

        public override bool CanCast(IPlayerSkill skill, IController hud) {
            var monsters = hud.Game.AliveMonsters.Where(m => ((m.SummonerAcdDynamicId == 0 && m.IsElite) || !m.IsElite || m.IsQuestMonster));
            int count = 0;
            foreach (var monster in monsters)
            {
                if (monster.FloorCoordinate.XYDistanceTo(hud.Game.Me.FloorCoordinate) <= radius) {
                    count++;
                    if (count > minAmount) return true;
                }
            }
            return false;
        }
     }

}