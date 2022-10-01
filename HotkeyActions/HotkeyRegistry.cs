using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.HotkeyActions {

    public static class HotkeyRegistry {

        private static List<HotkeyAction> hotkeyActions = new List<HotkeyAction>();

        public static void Load(IController hud) {
            hotkeyActions.Add(new SalvageAction(Keys.Space));
            hotkeyActions.Add(new CubeConverter(Keys.D6, true));
            hotkeyActions.Add(new CubeConverterAbort(Keys.Escape));
            hotkeyActions.Add(new LeaveGameAction(Keys.F1));

            foreach (HotkeyAction action in hotkeyActions)
            {
                action.Load(hud);
            }
        }

        public static void Execute(IController hud, IKeyEvent keyEvent) {
            HotkeyAction action = hotkeyActions.FirstOrDefault(hk => hk.Matches(hud, keyEvent) && hk.Aplicable(hud));
            if (action == null) return;
            action.Execute(hud);
        }

    }

}