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

    public class CubeConverterAbort : HotkeyAction {

        public CubeConverterAbort(Keys key, bool ctrl = false, bool shift = false, bool alt = false) : base(key, ctrl, shift, alt) {}

        public override bool Aplicable(IController hud)
        {
            return CubeConverter.ConverterExecutionThread != null && CubeConverter.ConverterExecutionThread.IsAlive;
        }

        public override void Execute(IController hud) {
            CubeConverter.ConverterExecutionThread.Abort();
        }

    }

}