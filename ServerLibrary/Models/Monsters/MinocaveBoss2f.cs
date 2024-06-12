using System;
using System.Collections;
using System.Collections.Generic;
using Library;
using Server.Envir;
using S = Library.Network.ServerPackets;

namespace Server.Models.Monsters
{
    public class MinocaveBoss2f : MonsterObject
    {
        DateTime deltaTime;
        int milisec;

        protected override void OnSpawned()
        {
            base.OnSpawned();
            deltaTime = SEnvir.Now;
            milisec = SEnvir.Random.Next(2000, 6000);
        }
        public override void ProcessTarget()
        {
            if (Target == null) return;

            if (InAttackRange())
            {
                if (!CanAttack) return;

                if (CurrentLocation == Target.CurrentLocation)
                {
                    MirDirection direction = (MirDirection)SEnvir.Random.Next(8);
                    int rotation = SEnvir.Random.Next(2) == 0 ? 1 : -1;

                    for (int d = 0; d < 8; d++)
                    {
                        if (Walk(direction)) break;

                        direction = Functions.ShiftDirection(direction, rotation);
                    }
                }

                AttackAoE(2, MagicType.HalfMoon, Element.Holy);

            }
            else
            { // Más lejos de 1 casilla del objetivo
                if (!CanAttack) return;

                if ((int)(SEnvir.Now - deltaTime).TotalMilliseconds >= milisec)
                {
                    RangeAttack();
                    deltaTime = SEnvir.Now;
                    milisec = SEnvir.Random.Next(2000, 6000);
                }
                else
                {
                    MoveTo(Target.CurrentLocation);
                }

            }
        }

        public void RangeAttack()
        {
            MassGustBlast();
        }
    }
}