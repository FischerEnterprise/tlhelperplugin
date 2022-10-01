using System.Collections.Generic;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Game;

namespace Turbo.Plugins.TL.Helper.Data.Kadala {

    public static class KadalaItems {

        public static void Init(IController hud) {
            WEAPON_1H   = new KadalaItem(hud, "1-H Weapon", 75, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.FIRST_ITEM);
            WEAPON_2H   = new KadalaItem(hud, "2-H Weapon", 75, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.SECOND_ITEM);
            QUIVER      = new KadalaItem(hud, "Quiver", 25, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.THIRD_ITEM);
            ORB         = new KadalaItem(hud, "Orb", 25, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.FOURTH_ITEM);
            MOJO        = new KadalaItem(hud, "Mojo", 25, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.FIFTH_ITEM);
            PHYLACTERY  = new KadalaItem(hud, "Phylactery", 25, UiPathConstants.Vendor.FIRST_TAB, UiPathConstants.Vendor.SIXTH_ITEM);

            HELM        = new KadalaItem(hud, "Helm", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.FIRST_ITEM);
            GLOVES      = new KadalaItem(hud, "Gloves", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.SECOND_ITEM);
            BOOTS       = new KadalaItem(hud, "Boots", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.THIRD_ITEM);
            CHEST_ARMOR = new KadalaItem(hud, "Chest Armor", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.FOURTH_ITEM);
            BELT        = new KadalaItem(hud, "Belt", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.FIFTH_ITEM);
            SHOULDERS   = new KadalaItem(hud, "Shoulders", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.SIXTH_ITEM);
            PANTS       = new KadalaItem(hud, "Pants", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.SEVENTH_ITEM);
            BRACERS     = new KadalaItem(hud, "Bracers", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.EIGHTH_ITEM);
            SHIELD      = new KadalaItem(hud, "Shield", 25, UiPathConstants.Vendor.SECOND_TAB, UiPathConstants.Vendor.NINTH_ITEM);
            
            RING    = new KadalaItem(hud, "Ring", 50, UiPathConstants.Vendor.THIRD_TAB, UiPathConstants.Vendor.FIRST_ITEM);
            AMULET  = new KadalaItem(hud, "Amulet", 100, UiPathConstants.Vendor.THIRD_TAB, UiPathConstants.Vendor.SECOND_ITEM);

            items.Add("1-H Weapon", WEAPON_1H);
            items.Add("2-H Weapon", WEAPON_2H);
            items.Add("Quiver", QUIVER);
            items.Add("orb", ORB);
            items.Add("Mojo", MOJO);
            items.Add("Phylactery", PHYLACTERY);

            items.Add("Helm", HELM);
            items.Add("Gloves", GLOVES);
            items.Add("Boots", BOOTS);
            items.Add("Chest Armor", CHEST_ARMOR);
            items.Add("Belt", BELT);
            items.Add("Shoulders", SHOULDERS);
            items.Add("Pants", PANTS);
            items.Add("Bracers", BRACERS);
            items.Add("Shield", SHIELD);

            items.Add("Ring", RING);
            items.Add("Amulet", AMULET);
        }

        public static string[] GetNames() {
            string[] names = new string[items.Count];
            items.Keys.CopyTo(names, 0);
            return names;
        }

        public static KadalaItem GetByName(string name) {
            return items[name];
        }

        private static Dictionary<string, KadalaItem> items = new Dictionary<string, KadalaItem>();

        public static KadalaItem WEAPON_1H;
        public static KadalaItem WEAPON_2H;
        public static KadalaItem QUIVER;
        public static KadalaItem ORB;
        public static KadalaItem MOJO;
        public static KadalaItem PHYLACTERY;
        public static KadalaItem HELM;
        public static KadalaItem GLOVES;
        public static KadalaItem BOOTS;
        public static KadalaItem CHEST_ARMOR;
        public static KadalaItem BELT;
        public static KadalaItem SHOULDERS;
        public static KadalaItem PANTS;
        public static KadalaItem BRACERS;
        public static KadalaItem SHIELD;
        public static KadalaItem RING;
        public static KadalaItem AMULET;

    }

}