using System.Linq;
using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class AutoPickup : AutoAction {

        public AutoPickup() {
            this.autoActionType = AutoActionType.SPAM;
            this.minDelay = 10;
        }

        protected override bool CheckAplicable(IController hud) {
            return hud.Game.SelectedActor != null && (! hud.Game.Me.IsInTown);
        }

        public override void Run(IController hud) {
            if (hud.Game.SelectedActor == null) return;
            if (hud.Game.SelectedActor.SnoActor.Type != ActorType.Item) return;

            InputSimulator.PostMessageMouseClickLeft();
        }

        private bool shouldPick(IController hud, IItem item) {
            if (item.Location != ItemLocation.Floor) return false; // Must be on the floor
            if (item.FloorCoordinate.XYDistanceTo(hud.Game.Me.FloorCoordinate) > 2) return false; // Must be in a 2 meter radius around player

            if (item.SnoItem.Kind == ItemKind.gem) return true; // Can be a gem
            if (item.SnoItem.Kind == ItemKind.craft) return true; // Can be a crafting material

            if (item.IsLegendary && item.AncientRank > 0) return true; // Can be ancient or primal

            if (item.SnoItem.Sno == 1844495708) return true; // Can be Ramaladin's Gift

            return false;
        }

    }

}