using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace Togie.PlagueGun
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 0.67f; //The default chance of adding a hediff.
        public HediffDef HediffToAdd;

        //public override void ResolveReferences()
        //{
        //    base.ResolveReferences();
        //    HediffToAdd = HediffDefOf.Plague;
        //}
    }
}
