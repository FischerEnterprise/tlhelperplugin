using System.Drawing;
using System.Windows.Forms;

using Turbo.Plugins;
using Turbo.Plugins.TL.Helper.Input;

namespace Turbo.Plugins.TL.Helper {

    public static class HudExtensions {

        public static void Click(this IUiElement uiElement)
        {
            uiElement.Rectangle.Click();
        }

        public static void RightClick(this IUiElement uiElement)
        {
            uiElement.Rectangle.RightClick();
        }

        public static void Click(this RectangleF rectangleF)
        {
            InputSimulator.PostMessageMouseClickLeft(rectangleF.GetCenter());
        }

        public static void RightClick(this RectangleF rectangleF)
        {
            InputSimulator.PostMessageMouseClickRight(rectangleF.GetCenter());
        }

        public static void Click(this IItem item)
        {
            InputSimulator.PostMessageMouseClickLeft((int)item.FloorCoordinate.ToScreenCoordinate().X, (int)item.FloorCoordinate.ToScreenCoordinate().Y);
        }

        public static void Cast(this IPlayerSkill skill)
        {
            Keys key = Keys.None;
            switch (skill.Key)
            {
                case ActionKey.Skill1: key = Keys.D1; break;
                case ActionKey.Skill2: key = Keys.D2; break;
                case ActionKey.Skill3: key = Keys.D3; break;
                case ActionKey.Skill4: key = Keys.D4; break;
                case ActionKey.LeftSkill: key = Keys.LButton; break;
                case ActionKey.RightSkill: key = Keys.RButton; break;
                default: return;
            }
            InputSimulator.PressKey(key);
        }

        public static bool CursorInsideRect(this IWindow window, RectangleF rectangle)
        {
            return window.CursorInsideRect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        private static Point GetCenter(this RectangleF rectangleF)
        {
            return new Point(
                (int)(rectangleF.X + (rectangleF.Width / 2)),
                (int)(rectangleF.Y + (rectangleF.Height / 2))
            );
        }

    }

}