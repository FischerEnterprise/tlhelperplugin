using System.Linq;
using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Data;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;

namespace Turbo.Plugins.TL.Helper.HotkeyActions {

    public class SalvageAction : HotkeyAction {

        public SalvageAction(Keys key, bool ctrl = false, bool shift = false, bool alt = false) : base(key, ctrl, shift, alt) {}

        public override bool Aplicable(IController hud)
        {
            return hud.Render.IsUiElementVisible(UiPathConstants.Blacksmith.ANVIL);
        }

        public override void Execute(IController hud) {
            if (!hud.Render.IsUiElementVisible(UiPathConstants.Blacksmith.ANVIL)) return;
            // int whiteItems = hud.Inventory.ItemsInInventory.Where(item => item.SnoItem.StackSize <= 0 && item.IsNormal).Count();
            // int blueItems = hud.Inventory.ItemsInInventory.Where(item => item.SnoItem.StackSize <= 0 && item.IsMagic).Count();
            // int yellowItems = hud.Inventory.ItemsInInventory.Where(item => item.SnoItem.StackSize <= 0 && item.IsRare).Count();

            // (string, bool)[] salvageButtons = new (string, bool)[] {
            //     (UiPathConstants.Blacksmith.SALVAGE_WHITE, whiteItems > 0),
            //     (UiPathConstants.Blacksmith.SALVAGE_BLUE, blueItems > 0),
            //     (UiPathConstants.Blacksmith.SALVAGE_RARE, yellowItems > 0),
            // };

            // foreach ((string salvageButton, bool active) in salvageButtons)
            // {
            //     if (!active) continue;

            //     hud.Render.GetOrRegisterAndGetUiElement(salvageButton).Click();
            //     InputSimulator.PressKey(Keys.Enter);
            // }

            hud.Render.GetOrRegisterAndGetUiElement(UiPathConstants.Blacksmith.ANVIL).Click();

            foreach (IItem item in hud.Inventory.ItemsInInventory.ToList())
            {
                if (shouldSalvage(hud, item)) {
                    hud.Inventory.GetItemRect(item).Click();
                    Thread.Sleep(10);
                    if (item.IsLegendary) {
                        InputSimulator.PressKey(Keys.Enter);
                        Thread.Sleep(30);
                    }
                }
            }
        }

        private bool shouldSalvage(IController hud, IItem item) {
            if (item.JewelRank > -1) return false; // dont salvage gems

            if (item.SnoItem.StackSize > 0) return false; // dont salvage stackables (gems, ramaladins, etc.)

            if (item.IsNormal || item.IsMagic || item.IsRare) return true; // salvage all yellow, blue and greys

            if (hud.Game.Me.ArmorySets.Any(set => set.ContainsItem(item))) return false; // dont salvage items used in an armory set

            if (item.AncientRank == 2) return false; // dont salvage primals

            foreach (var stat in item.StatList) {
                if (stat.Id != null && stat.Attribute != null && stat.Attribute.Code != null) {
                    if (stat.Attribute.Code.Equals("DyeType")) { // dont salvage died items
                        return false;
                    }
                    if (stat.Attribute.Code.Equals("TransmogGBID")) { // dont salvage transmoged items
                        return false;
                    }
                    if (stat.Attribute.Code.Equals("EnchantedAffixCount")) { // dont salvage enchanted items
                        return false;
                    }
                }
            }

            if (SalvageDefinitions.KEEP_LIST.Contains(item.SnoItem.NameEnglish)) return false; // dont salvage items on the keep list

            if (SalvageDefinitions.SALVAGE_LIST.Contains(item.SnoItem.NameEnglish)) return true; // salvage all items on the salvage list
            
            return (item.AncientRank < 1); // salvage undefined items if not ancient or primal
        }

    }

}