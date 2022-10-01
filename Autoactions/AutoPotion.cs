using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class AutoPotion : AutoAction {

        public AutoPotion() {
            this.autoActionType = AutoActionType.ONCE;
        }

        protected override bool CheckAplicable(IController hud) {
            return (
                !hud.Game.Me.Powers.HealthPotionSkill.IsOnCooldown &&
                hud.Game.Me.Defense.HealthPct < 30 &&
                MainWindow.GetInstance().Settings["auto_potion"] == "enabled"
            );
        }

        public override void Run(IController hud) {
            InputSimulator.PressKey(Keys.Q);
        }

    }

}