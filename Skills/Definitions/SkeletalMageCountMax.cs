using System.Linq;
using Turbo.Plugins;

namespace Turbo.Plugins.TL.Helper.Skills.Definitions {

    public class SkeletalMageCountMax : CastDefinition {

        private float maxValue;

        public SkeletalMageCountMax(int maxValue) {
            this.maxValue = maxValue;
        }

        public override bool CanCast(IPlayerSkill skill, IController hud) {
            return hud.Game.Actors.Where(EachActor => 
                    (
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_a || // no rune
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_b || // gift of death
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_c || // contamination
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_d || // life support
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_e || // singularity
                        EachActor.SnoActor.Sno == ActorSnoEnum._p6_necro_skeletonmage_f_archer // archer
                    ) &&
                    EachActor.SummonerAcdDynamicId == hud.Game.Me.SummonerId
                ).Count() <= this.maxValue;
        }
     }

}