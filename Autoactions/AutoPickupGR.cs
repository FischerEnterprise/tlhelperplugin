using System.Linq;
using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Input;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class AutoPickupGR : AutoAction {

        public AutoPickupGR() {
            this.autoActionType = AutoActionType.SPAM;
            this.minDelay = 150;
        }

        protected override bool CheckAplicable(IController hud) {
            return (
                (hud.Game.Items.Where(item => item.Location == ItemLocation.Floor).Count() > 0) &&
                ShouldUpGems(hud) &&
                hud.Game.SpecialArea == SpecialArea.GreaterRift
            );
        }

        public override void Run(IController hud) {
            var item = hud.Game.Items.Where(i => i.Location == ItemLocation.Floor).First();
            InputSimulator.PostMessageClickWithMouseMove("LMB", (int) item.ScreenCoordinate.X, (int) item.ScreenCoordinate.Y);
        }

        private bool ShouldUpGems(IController hud)
        {
            if (hud.Game.Quests.FirstOrDefault(quest => quest.SnoQuest.Sno == hud.Sno.SnoQuests.NephalemRift_337492.Sno) is IQuest riftQuest)
                return riftQuest.QuestStepId == 34;

            return false;
        }

    }

}