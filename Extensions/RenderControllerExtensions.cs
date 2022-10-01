using System;
using System.Threading;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Input;
using Turbo.Plugins.TL.Helper.Executors;


namespace Turbo.Plugins.TL.Helper.Extensions {
    public static class RenderControllerExtensions
    {
        public static void WaitForVisiblityAndRightClickOrAbortHotkeyEvent(this IRenderController renderController, string path,
            int maxWaitTimeMs = 2000, int intervalMs = 25)
        {
            WaitForVisiblityAndClickOrAbortHotkeyEvent(renderController, path, maxWaitTimeMs, intervalMs, false);
        }

        public static void WaitForVisiblityAndClickOrAbortHotkeyEvent(this IRenderController renderController, string path,
            int maxWaitTimeMs = 2000, int intervalMs = 25, bool leftClick = true)
        {
            WaitForConditionOrAbortHotkeyEvent(() => renderController.IsUiElementVisible(path), maxWaitTimeMs, intervalMs);
            if (leftClick)
                renderController.GetOrRegisterAndGetUiElement(path).Click();
            else
                renderController.GetOrRegisterAndGetUiElement(path).RightClick();
        }

        public static void WaitForConditionOrAbortHotkeyEvent(Func<bool> condition, int maxWaitTimeMs = 2000, int intervalMs = 25)
        {
            var result = new TimedRetryExecutor(maxWaitTimeMs, intervalMs, condition).Invoke();
        }

        public static void CloseChatAndOpenWindows(this IRenderController renderController)
        {
            if (renderController.IsUiElementVisible(UiPathConstants.Ui.CHAT_INPUT))
            {
                InputSimulator.PressKey(Keys.Escape);
                WaitForConditionOrAbortHotkeyEvent(() => !renderController.IsUiElementVisible(UiPathConstants.Ui.CHAT_INPUT));
            }

            InputSimulator.PressKey(Keys.Oemplus);
            Thread.Sleep(25);
        }

        public static bool IsUiElementVisible(this IRenderController renderController, string path)
        {
            var uiElement = renderController.GetOrRegisterAndGetUiElement(path);
            return !(uiElement is null) && uiElement.Visible;
        }

        public static IUiElement GetOrRegisterAndGetUiElement(this IRenderController renderController, string path)
        {
            var layer = renderController.GetUiElement(path) ??
                        renderController.RegisterUiElement(path, null, null);

            return layer;
        }

        public static bool IsShopOpen(this IRenderController renderController)
        {
            return renderController.IsUiElementVisible(UiPathConstants.Vendor.CURRENCY_TYPE);
        }
    }
}