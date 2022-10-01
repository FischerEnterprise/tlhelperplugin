using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Input;

namespace Turbo.Plugins.TL.Helper.HotkeyActions {

    public abstract class HotkeyAction {

        private Keys key;
        private bool shift;
        private bool ctrl;
        private bool alt;

        public HotkeyAction(Keys key, bool ctrl = false, bool shift = false, bool alt = false) {
            this.key = key;
            this.ctrl = ctrl;
            this.shift = shift;
            this.alt = alt;
        }

        public bool Matches(IController hud, IKeyEvent keyEvent) {
            IKeyEvent ownEvent = hud.Input.CreateKeyEvent(true, InputUtil.KeysToKey(this.key), this.ctrl, this.alt, this.shift);
            return ownEvent.Matches(keyEvent);
        }
        
        public virtual void Load(IController hud) {}

        public abstract bool Aplicable(IController hud);
        public abstract void Execute(IController hud);

    }

}