using System;
using System.IO;
using System.Linq;
using System.Threading;

using Turbo.Plugins;
using Turbo.Plugins.Default;
using Turbo.Plugins.TL.Helper.UI;
using Turbo.Plugins.TL.Helper.Game;
using Turbo.Plugins.TL.Helper.Skills;
using Turbo.Plugins.TL.Helper.Extensions;
using Turbo.Plugins.TL.Helper.Autoactions;
using Turbo.Plugins.TL.Helper.Data.Kadala;
using Turbo.Plugins.TL.Helper.HotkeyActions;
using Turbo.Plugins.TL.Helper.Special;

namespace Turbo.Plugins.TL.Helper {

    public class TLHelper : BasePlugin, IInGameTopPainter, IKeyEventHandler, IAfterCollectHandler
    {
        private SkillExecutor skillExecutor;
        private MainWindow mainWindow;
        private Thread mainWindowThread;

        public TLHelper() {
            Enabled = true;
        }

        public override void Load(IController hud) {
            base.Load(hud);

            // Load Data Classes
            KadalaItems.Init(hud);

            // Load Settings
            string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\settings.ini";
            string settings = "";

            if (File.Exists(settingsPath))
                settings = File.ReadAllText(settingsPath);

            // Load UI
            mainWindow = new MainWindow(settings);
            mainWindowThread = new Thread(() => {
                mainWindow.ShowDialog();
            });
            mainWindowThread.SetApartmentState(ApartmentState.STA);
            mainWindowThread.Start();

            // Load Logic
            skillExecutor = new SkillExecutor();
            DefinitionGroupLoader.Load(skillExecutor);
            AutoActionLoader.Load(hud);
            HotkeyRegistry.Load(hud);
        }

        public void OnKeyEvent(IKeyEvent keyEvent) {
            HotkeyRegistry.Execute(Hud, keyEvent);
        }

        public void PaintTopInGame(ClipState clipState) {

        }

        public void AfterCollect() {
            if (Hud.Game.IsLoading || Hud.Game.IsPaused || !D3Client.IsInForeground()) return;

            AutoActionLoader.Execute(Hud);

            if (CharacterCanCast())
                ExecuteSkills();

            CheckSkillChanges();
        }

        private void ExecuteSkills()
        {
            Hud.Game.Me.Powers.CurrentSkills.ForEach(skill =>
                skillExecutor.Cast(skill, Hud)
            );
            
            if (Hud.Game.Me.Powers.BuffIsActive(318817)) // hexing pants equiped
                if (Hud.Game.Me.AnimationState == AcdAnimationState.Idle || Hud.Game.Me.AnimationState == AcdAnimationState.Casting) // char not moving
                    HexingPants.Move();
        }
        
        private bool CharacterCanCast()
        {
            if (ShouldUpGems()) // Must not be done with a GR
                return false;

            return Hud.Game.IsInGame // Must be in game
                   && !Hud.Game.IsInTown // Must not be in town
                   && !Hud.Game.IsLoading // Must not be loading
                   && Hud.Game.MapMode == MapMode.Minimap // Must not have map opened
                   && !Hud.Game.Me.IsDead // Must not be dead
                   && Hud.Game.Me.AnimationState != AcdAnimationState.CastingPortal // Must not be casting a portal
                   && !Hud.Render.IsUiElementVisible(UiPathConstants.Ui.CHAT_INPUT) // Must not have chat open
                   && (Hud.Inventory.InventoryMainUiElement == null || !Hud.Inventory.InventoryMainUiElement.Visible) // Must not have inventory open
                   && !Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_ActorInvulBuff.Sno) // Must not have invulneribility (ghost)
                   && !Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_TeleportToPlayerCast.Sno) // Must not cast player tp portal
                   && !Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_TeleportToWaypointCast.Sno) // Must not cast waypoint tp portal
                   && !Hud.Game.Me.Powers.BuffIsActive(Hud.Sno.SnoPowers.Generic_AxeOperateGizmo.Sno); // ???
        }

        private bool ShouldUpGems()
        {
            if (Hud.Game.Quests.FirstOrDefault(quest => quest.SnoQuest.Sno == Hud.Sno.SnoQuests.NephalemRift_337492.Sno) is IQuest riftQuest)
                return riftQuest.QuestStepId == 34;

            return false;
        }

        private void CheckSkillChanges() {
            if (!Hud.Game.IsInGame) return; // Must be in game
            if (Hud.Game.IsLoading) return; // Must not be loading

            string[] skills = new string[] {
                "No Skill",
                "No Skill",
                "No Skill",
                "No Skill",
                "No Skill",
                "No Skill",
            };

            Hud.Game.Me.Powers.CurrentSkills.ForEach(skill => {
                skills[(int)skill.Key] = skill.SnoPower.NameLocalized;
            });

            mainWindow.UpdateSkills(skills);
        }

    }

}