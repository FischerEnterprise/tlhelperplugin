using System.Linq;
using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Data;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;

namespace Turbo.Plugins.TL.Helper.HotkeyActions {

    public class LeaveGameAction : HotkeyAction {

        public LeaveGameAction(Keys key, bool ctrl = false, bool shift = false, bool alt = false) : base(key, ctrl, shift, alt) {}

        public override void Load(IController hud) {
            hud.Render.RegisterUiElement(UiPathConstants.Buttons.GAME_MENU, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.Buttons.LEAVE_GAME, null, null);
        }

        public override bool Aplicable(IController hud)
        {
            return hud.Game.IsInGame && !hud.Game.IsLoading;
        }

        public override void Execute(IController hud) {
            // Close map if open
            if (hud.Game.MapMode != MapMode.Minimap)
                InputSimulator.PressKey(Keys.Escape);

            // Press game menu button
            hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.Buttons.GAME_MENU).Click();

            // Sleep to give the game some time
            Thread.Sleep(50);

            // Press leave game button
            hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.Buttons.LEAVE_GAME).Click();
        }

    }

}