using System.Linq;
using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class ItemDebug : AutoAction {

        protected override bool CheckAplicable(IController hud) {
            
            return hud.Game.SelectedActor != null;
        }

        public override void Run(IController hud) {
            if (hud.Game.SelectedActor == null) return;
            if (hud.Game.SelectedActor.SnoActor.Type != ActorType.Item) return;

            InputSimulator.PostMessageMouseClickLeft();

            // IItem item = (IItem) hud.Game.SelectedActor;

            // hud.TextLog.Log("TL.Item", $"Item info for \"{item.SnoItem.NameLocalized}\" ({item.SnoItem.Sno})", false);
            // hud.TextLog.Log("TL.Item", $"Ancient Rank: {item.AncientRank}", false);
            // hud.TextLog.Log("TL.Item", $"Caldesan Rank: {item.CaldesannRank}", false);
            // hud.TextLog.Log("TL.Item", $"Jewel Rank: {item.JewelRank}", false);
            // hud.TextLog.Log("TL.Item", "", false);
            // hud.TextLog.Log("TL.Item", $"Normal: {item.IsNormal}", false);
            // hud.TextLog.Log("TL.Item", $"Magic: {item.IsMagic}", false);
            // hud.TextLog.Log("TL.Item", $"Rare: {item.IsRare}", false);
            // hud.TextLog.Log("TL.Item", $"Legendary: {item.IsLegendary}", false);
            // hud.TextLog.Log("TL.Item", "", false);
            // hud.TextLog.Log("TL.Item", $"Item Quality: {item.Quality}", false);
            // hud.TextLog.Log("TL.Item", "------------------------------", false);
            // hud.TextLog.Log("TL.Item", "", false);
        }

    }

}