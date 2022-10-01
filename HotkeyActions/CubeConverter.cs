using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Data;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Extensions;

namespace Turbo.Plugins.TL.Helper.HotkeyActions {

    public class CubeConverter : HotkeyAction {

        public static Thread ConverterExecutionThread;
        private RectangleF cubeButtonFill = new RectangleF(957, 1121, 10, 10);
        private RectangleF cubeButtonTransmute = new RectangleF(315, 1106, 10, 10);
        private RectangleF cubeButtonLeft = new RectangleF(-180, 1121, 10, 10);
        private RectangleF cubeButtonRight = new RectangleF(180, 1121, 10, 10);

        public CubeConverter(Keys key, bool ctrl = false, bool shift = false, bool alt = false) : base(key, ctrl, shift, alt) {
            float bh = 1440, bw = 3440, h = 1080, w = 1920;
            cubeButtonFill.X = (int)(cubeButtonFill.X * (h / bh));
            cubeButtonFill.Y = (int)(cubeButtonFill.Y * (h / bh));

            cubeButtonTransmute.X = (int)(cubeButtonTransmute.X * (h / bh));
            cubeButtonTransmute.Y = (int)(cubeButtonTransmute.Y * (h / bh));

            cubeButtonLeft.X = cubeButtonFill.X + ((int)(cubeButtonLeft.X * (h/bh)));
            cubeButtonLeft.Y = cubeButtonFill.Y;

            cubeButtonRight.X = cubeButtonFill.X + ((int)(cubeButtonRight.X * (h/bh)));
            cubeButtonRight.Y = cubeButtonFill.Y;
        }

        public override bool Aplicable(IController hud)
        {
            return (
                hud.Game.Me.IsInTown &&
                hud.Inventory.InventoryMainUiElement.Visible
            );
        }

        public override void Execute(IController hud) {
            ConverterExecutionThread = new Thread(() => execute(hud));
            ConverterExecutionThread.Start();
            hud.TextLog.Log("TL", "converter thread started");

            hud.TextLog.Log("TL", $"CubeButtonFill({cubeButtonFill.X}, {cubeButtonFill.X})");
            hud.TextLog.Log("TL", $"CubeButtonTransmute({cubeButtonTransmute.X}, {cubeButtonTransmute.X})");
            hud.TextLog.Log("TL", $"CubeButtonLeft({cubeButtonLeft.X}, {cubeButtonLeft.X})");
            hud.TextLog.Log("TL", $"CubeButtonRight({cubeButtonRight.X}, {cubeButtonRight.X})");
        }

        private void execute(IController hud) {
            hud.TextLog.Log("TL", "converting ...");
            var items = hud.Inventory.ItemsInInventory.Where((item) => ((item.SnoItem.StackSize <= 0) && item.IsRare)).ToArray();
            foreach (var item in items)
            {
                hud.Inventory.GetItemRect(item).RightClick();
                Thread.Sleep(50);
                cubeButtonFill.Click();
                Thread.Sleep(50);
                cubeButtonTransmute.Click();
                Thread.Sleep(100);
                cubeButtonRight.Click();
                Thread.Sleep(50);
                cubeButtonLeft.Click();
                Thread.Sleep(50);
            }
            hud.TextLog.Log("TL", "done converting");
        }

    }

}