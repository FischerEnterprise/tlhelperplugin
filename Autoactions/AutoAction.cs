using System;
using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Autoactions {

    public abstract class AutoAction {

        protected AutoActionType autoActionType = AutoActionType.ONCE;

        protected long minDelay = 500;
        private long lastExecution = 0;
        private bool lastCheck = false;

        protected bool checkExecutionTime() {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds() - lastExecution > minDelay;
        }

        protected void updateExecutionTime() {
            lastExecution = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public bool Aplicable(IController hud) {
            bool isSatisfied = CheckAplicable(hud);

            if (autoActionType == AutoActionType.ONCE) {
                if (lastCheck) {
                    lastCheck = isSatisfied;
                    return false;
                }
            }

            lastCheck = isSatisfied && checkExecutionTime();
            return lastCheck;
        }

        public virtual void Load(IController hud) {}

        protected abstract bool CheckAplicable(IController hud);
        public abstract void Run(IController hud);

    }

}