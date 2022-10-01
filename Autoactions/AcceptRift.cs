using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class AcceptRift : AutoAction {

        public override void Load(IController hud) {
            hud.Render.RegisterUiElement(UiPathConstants.Dialogs.GREATER_RIFT_INVITE, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.ACCEPT_BUTTON, null, null);
        }

        protected override bool CheckAplicable(IController hud) {
            return (
                hud.Render.IsUiElementVisible(UiPathConstants.Dialogs.GREATER_RIFT_INVITE) &&
                MainWindow.GetInstance().Settings["auto_accept_rift"] == "enabled"
            );
        }

        public override void Run(IController hud) {
            hud.TextLog.Log("TL", "Running Script: Auto Accept Rift");

            // hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.RiftObelisk.ACCEPT_BUTTON).Click();
            InputSimulator.PostMessageMouseClickLeft(800, 900);
        }

    }

}