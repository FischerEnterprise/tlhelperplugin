using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class CloseDialogs : AutoAction {

        public override void Load(IController hud) {
            hud.Render.RegisterUiElement(UiPathConstants.Dialogs.CONVERSATION, null, null);
        }

        protected override bool CheckAplicable(IController hud) {
            return (
                hud.Render.IsUiElementVisible(UiPathConstants.Dialogs.CONVERSATION) &&
                MainWindow.GetInstance().Settings["close_rift_dialogs"] == "enabled"
            );
        }

        public override void Run(IController hud) {
            InputSimulator.PressKey(Keys.Escape);
        }

    }

}