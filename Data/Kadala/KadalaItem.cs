using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Extensions;

namespace Turbo.Plugins.TL.Helper.Data.Kadala {

    public class KadalaItem {

        public int Cost {get { return cost; } }
        public string Name {get { return name; } }
        public IUiElement TabUiElement {get { return tabUiElement; } }
        public IUiElement ItemUiElement {get { return itemUiElement; } }

        private int cost;
        private string name;
        private IUiElement tabUiElement;
        private IUiElement itemUiElement;

        public KadalaItem(IController hud, string name, int cost, string tabUiElementPath, string itemUiElementPath) {
            this.name = name;
            this.cost = cost;
            this.tabUiElement = hud.Render.GetOrRegisterAndGetUiElement(tabUiElementPath);
            this.itemUiElement = hud.Render.GetOrRegisterAndGetUiElement(itemUiElementPath);
        }

    }

}