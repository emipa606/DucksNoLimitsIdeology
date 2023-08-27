using HarmonyLib;
using RimWorld;
using Verse;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoFoundation))]
[HarmonyPatch("InitPrecepts")]
public class DucksNoIdeologyLimits_InitPrecepts
{
    //public static void Prefix(ref IntRange ___MemeCountRangeAbsolute, ref int ___MaxStyleCategories, ref int ___MaxRituals, ref int ___MaxMultiRoles)
    public static void Prefix(ref IntRange ___MemeCountRangeAbsolute, IdeoGenerationParms parms)
    {
        if (DucksNoIdeologyLimitsMod.instance.Settings.OnlyPlayer && !parms.forFaction.isPlayer)
        {
            return;
        }

        ___MemeCountRangeAbsolute = new IntRange(0, 1000);
        //___MaxStyleCategories = 1000;
        //___MaxRituals = 1000;
        //___MaxMultiRoles = 1000;
    }
}