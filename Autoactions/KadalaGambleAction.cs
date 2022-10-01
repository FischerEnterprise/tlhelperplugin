using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class KadalaGambleAction : AutoAction {

        protected override bool CheckAplicable(IController hud) {
            return hud.Render.IsUiElementVisible(UiPathConstants.Vendor.CURRENCY_TYPE);
        }

        public override void Run(IController hud) {
            // hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.Vendor.SIXTH_ITEM).RightClick();
            KadalaItem item = KadalaItems.GetByName(MainWindow.GetInstance().Settings["kadala_item"]);
            Thread.Sleep(100);
            item.TabUiElement.Click();
            Thread.Sleep(10);
            for (int i = 0; i < (int) (hud.Game.Me.Materials.BloodShard / item.Cost); i++)
            {
                item.ItemUiElement.RightClick();
            }
        }

    }

}