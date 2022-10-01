using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Data.Kadala;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public class OpenRift : AutoAction {

        public override void Load(IController hud) {
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.OBELISK_WINDOW, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.NORMAL_RIFT_BUTTON, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.GREATER_RIFT_BUTTON, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.EMPOWERED_CHECKBOX, null, null);
            hud.Render.RegisterUiElement(UiPathConstants.RiftObelisk.ACCEPT_BUTTON, null, null);
        }

        protected override bool CheckAplicable(IController hud) {
            // hud.TextLog.Log("TL", "Obelisk visible: " + (hud.Render.IsUiElementVisible(UiPathConstants.RiftObelisk.OBELISK_WINDOW) ? "True" : "False"));
            // hud.TextLog.Log("TL", "Auto Open Rift: " + MainWindow.GetInstance().Settings["auto_open_rift"]);
            return (
                hud.Render.IsUiElementVisible(UiPathConstants.RiftObelisk.OBELISK_WINDOW) &&
                MainWindow.GetInstance().Settings["auto_open_rift"] != "disabled"
            );
        }

        public override void Run(IController hud) {
            bool empower = MainWindow.GetInstance().Settings["auto_empower_gr"] == "enabled";
            bool rift = MainWindow.GetInstance().Settings["auto_open_rift"] == "rift";

            Thread.Sleep(100);

            if (rift) {
                hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.RiftObelisk.NORMAL_RIFT_BUTTON).Click();
            } else {
                hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.RiftObelisk.GREATER_RIFT_BUTTON).Click();

                if (empower) {
                    var empoweredCheckboxUiElement = hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.RiftObelisk.EMPOWERED_CHECKBOX);
                    if (empoweredCheckboxUiElement.AnimState != 5 && empoweredCheckboxUiElement.AnimState != 6) {
                        empoweredCheckboxUiElement.Click();
                    }
                }
            }

            hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.RiftObelisk.ACCEPT_BUTTON).Click();
        }

    }

}