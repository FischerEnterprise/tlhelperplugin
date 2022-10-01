using System.Linq;
using System.Collections.Generic;

using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class DDInRange : CastDefinition {
        public override bool CanCast(IPlayerSkill skill, IController hud) {
            bool BossIsSpawned = (hud.Game.AliveMonsters.Count(m => m.SnoMonster.Priority == MonsterPriority.boss) > 0);
            bool RatParty = true;
            List<IPlayer> dds = new List<IPlayer>();

            foreach (IPlayer player in hud.Game.Players)
            {
                if (player.IsMe) continue;

                bool isDD = false;

                #region NECROMANCERS
                if (player.HeroClassDefinition.HeroClass == HeroClass.Necromancer) {
                    // LoD Rat Necro
                    if (player.Powers.BuffIsActive(483319) && player.Powers.BuffIsActive(403466)) { // legacy of dreams && enforcer
                        RatParty = true;
                        dds.Add(player);
                        isDD = true;
                    }

                    // Boss Killers
                    if (BossIsSpawned) {

                    }
                    // Trash Killers
                    else {
                        // Grim Scythe Necro
                        if (player.Powers.BuffIsActive(403469)) { // simplicitys strength
                            dds.Add(player);
                            isDD = true;
                        }
                    }
                }
                #endregion

                #region Demon Hunter
                else if (player.HeroClassDefinition.HeroClass == HeroClass.DemonHunter) {
                    // Boss Killers
                    if (BossIsSpawned) {

                    }
                    // Trash Killers
                    else {
                        // Marauder DH
                        if (player.Powers.BuffIsActive(403466)) { // enforcer
                            dds.Add(player);
                            isDD = true;
                        }
                    }
                }
                #endregion

                #region Witch Doctor
                else if (player.HeroClassDefinition.HeroClass == HeroClass.WitchDoctor) {
                    // Boss Killers
                    if (BossIsSpawned) {
                        // Arachyr WD
                        if (player.Powers.BuffIsActive(486133)) { // the spider queens grasp
                            dds.Add(player);
                            isDD = true;
                        }
                    }
                    // Trash Killers
                    else {
                        // Mundunungu WD
                        if (player.Powers.BuffIsActive(446969)) { // voo's juicer
                            dds.Add(player);
                            isDD = true;
                        }
                    }
                }
                #endregion

                #region Monk
                else if (player.HeroClassDefinition.HeroClass == HeroClass.Monk) {
                    // Boss Killers
                    if (BossIsSpawned) {
                        // Inna BK Monk
                        if (player.Powers.BuffIsActive(485725) && player.Powers.BuffIsActive(428348)) { // bindings of the lesser gods && bane of the stricken
                            dds.Add(player);
                            isDD = true;
                        }
                    }
                    // Trash Killers
                    else {
                    }
                }
                #endregion
            
                // check buffable
                if (isDD) {
                    uint[] badBuffs = new uint[] {
                        212032, // loading buff
                        224639, // ghosted buff
                        439438, // invulnerable buff
                        30582   // untargetable buff
                    };
                    foreach (uint buff in badBuffs)
                    {
                        if (player.Powers.BuffIsActive(buff))
                            return false;
                    }
                }
            }

            // Always satisfied without dds found
            if (dds.Count() == 0) return true;

            // For Rats: Satisfied if one dd is alive and in range
            return dds.FirstOrDefault(dd => (!dd.IsDead) && (dd.CentralXyDistanceToMe <= 45)) != null;

            // Satisfied if all important dds are alive and in range
            return dds.TrueForAll(dd => (!dd.IsDead) && (dd.CentralXyDistanceToMe <= 45));
        }
     }

}