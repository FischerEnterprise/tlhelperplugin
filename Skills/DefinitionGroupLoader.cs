using Turbo.Plugins.TL.Helper.Skills.Sno;
using Turbo.Plugins.TL.Helper.Skills.Definitions;
using Turbo.Plugins.TL.Helper.Skills.DefinitionGroups;

namespace Turbo.Plugins.TL.Helper.Skills {

    public static class DefinitionGroupLoader {

        public static void Load(SkillExecutor executor) {
            #region NECRO CAST CONDITIONS
                
                CastDefinitionGroup devour = new CastDefinitionGroup(executor, (uint) NecromancerSkills.Devour);
                devour.CastDefinitions.Add(new Runes("Satiated", "Ruthless", "Voracious", "Cannibalize"));

                CastDefinitionGroup landOfTheDead = new CastDefinitionGroup(executor, (uint) NecromancerSkills.LandOfTheDead);
                landOfTheDead.CastDefinitions.Add(new Runes("Frozen Lands"));
                landOfTheDead.CastDefinitions.Add(new OwnBuffInactive());
                landOfTheDead.CastDefinitions.Add(new Cooldown());
                landOfTheDead.CastDefinitions.Add(new MobsInRadius(75));

                CastDefinitionGroup simulacrum = new CastDefinitionGroup(executor, (uint) NecromancerSkills.Simulacrum);
                simulacrum.CastDefinitions.Add(new OwnBuffInactive());
                simulacrum.CastDefinitions.Add(new Cooldown());
                simulacrum.CastDefinitions.Add(new MobsInRadius(75));

                CastDefinitionGroup boneArmor = new CastDefinitionGroup(executor, (uint) NecromancerSkills.BoneArmor);
                boneArmor.CastDefinitions.Add(new Cooldown());
                boneArmor.CastDefinitions.Add(new MobsInRadius(25));

                CastDefinitionGroup commandSkeletonsDefault = new CastDefinitionGroup(executor, (uint) NecromancerSkills.CommandSkeletons);
                commandSkeletonsDefault.CastDefinitions.Add(new Resource());
                commandSkeletonsDefault.CastDefinitions.Add(new MobSelected());

                CastDefinitionGroup skeletalMageElite = new CastDefinitionGroup(executor, (uint) NecromancerSkills.SkeletalMage);
                skeletalMageElite.AplicableDefinitions.Add(new MobSelected(true));
                skeletalMageElite.CastDefinitions.Add(new Runes("Singularity", "Life Support"));
                skeletalMageElite.CastDefinitions.Add(new ResourceAbove(95));

                CastDefinitionGroup skeletalMageDefault = new CastDefinitionGroup(executor, (uint) NecromancerSkills.SkeletalMage);
                skeletalMageDefault.CastDefinitions.Add(new Runes("Singularity", "Life Support"));
                skeletalMageDefault.CastDefinitions.Add(new MobsInRadius(75));
                skeletalMageDefault.CastDefinitions.Add(new ResourceAbove(95));
                skeletalMageDefault.CastDefinitions.Add(new SkeletalMageCountMax(9));

            #endregion

            #region BARBARIAN CAST CONDITIONS
                
                CastDefinitionGroup sprint = new CastDefinitionGroup(executor, (uint) BarbarianSkills.Sprint);
                sprint.CastDefinitions.Add(new OwnBuffInactive());
                sprint.CastDefinitions.Add(new Cooldown());
                sprint.CastDefinitions.Add(new Resource());

                CastDefinitionGroup ignorePainSolo = new CastDefinitionGroup(executor, (uint) BarbarianSkills.IgnorePain);
                ignorePainSolo.AplicableDefinitions.Add(new Runes("Bravado", "Iron Hude", "Ignorance is Bliss", "Contempt for Weakness"));
                ignorePainSolo.CastDefinitions.Add(new OwnBuffInactive());
                ignorePainSolo.CastDefinitions.Add(new Cooldown());

                CastDefinitionGroup ignorePainGroup = new CastDefinitionGroup(executor, (uint) BarbarianSkills.IgnorePain);
                ignorePainGroup.AplicableDefinitions.Add(new Runes("Mob Rule"));
                ignorePainGroup.CastDefinitions.Add(new Cooldown());
                ignorePainGroup.CastDefinitions.Add(new DDInRange());

                CastDefinitionGroup threateningShoutFalter = new CastDefinitionGroup(executor, (uint) BarbarianSkills.ThreateningShout);
                threateningShoutFalter.AplicableDefinitions.Add(new Runes("Falter"));
                threateningShoutFalter.CastDefinitions.Add(new Cooldown());
                threateningShoutFalter.CastDefinitions.Add(new MobsInRadius(25));

                CastDefinitionGroup warCry = new CastDefinitionGroup(executor, (uint) BarbarianSkills.WarCry);
                warCry.CastDefinitions.Add(new Cooldown());

                CastDefinitionGroup battleRage = new CastDefinitionGroup(executor, (uint) BarbarianSkills.BattleRage);
                battleRage.CastDefinitions.Add(new OwnBuffInactive());
                battleRage.CastDefinitions.Add(new Cooldown());
                battleRage.CastDefinitions.Add(new Resource());

                CastDefinitionGroup callOfTheAncients = new CastDefinitionGroup(executor, (uint) BarbarianSkills.CallOfTheAncients);
                callOfTheAncients.CastDefinitions.Add(new OwnBuffInactive());
                callOfTheAncients.CastDefinitions.Add(new Cooldown());

                CastDefinitionGroup wrathOfTheBerserker = new CastDefinitionGroup(executor, (uint) BarbarianSkills.WrathOfTheBerserker);
                wrathOfTheBerserker.CastDefinitions.Add(new OwnBuffInactive());
                wrathOfTheBerserker.CastDefinitions.Add(new Cooldown());


            #endregion
        }

    }

}