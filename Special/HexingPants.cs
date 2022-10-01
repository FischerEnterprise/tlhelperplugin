using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Turbo.Plugins.TL.Helper.Input;

namespace Turbo.Plugins.TL.Helper.Special
{
    public static class HexingPants
    {
        private static double sx, sy;
        private static bool currentState = false;
        private static int lastClick = 0;

        static HexingPants()
        {
            sx = 1;
            sy = 1;
        }

        public static void Move()
        {
            if (Environment.TickCount - lastClick <= 25) return;

            if (currentState)
                InputSimulator.PostMessageKeyPress("MMB", (int)sx * (961 + 75), (int)sy * 507);
            else
                InputSimulator.PostMessageKeyPress("MMB", (int)sx * (961 - 75), (int)sy * 507);

            lastClick = Environment.TickCount;
            currentState = !currentState;
        }


    }
}