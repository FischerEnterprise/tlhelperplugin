using System.Collections.Generic;

using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public static class AutoActionLoader {

        private static List<AutoAction> autoActions = new List<AutoAction>();

        public static void Load(IController hud) {
            autoActions.Add(new KadalaGambleAction());
            autoActions.Add(new AutoPickup());
            autoActions.Add(new AutoPotion());
            autoActions.Add(new AutoPickupGR());
            autoActions.Add(new OpenRift());
            autoActions.Add(new CloseDialogs());
            autoActions.Add(new AcceptRift());
            // autoActions.Add(new ItemDebug());

            foreach (AutoAction autoAction in autoActions)
            {
                autoAction.Load(hud);
            }
        }

        public static void Execute(IController hud) {
            foreach (AutoAction autoAction in autoActions)
            {
                if (autoAction.Aplicable(hud)) {
                    autoAction.Run(hud);
                }
            }
        }

    }

}