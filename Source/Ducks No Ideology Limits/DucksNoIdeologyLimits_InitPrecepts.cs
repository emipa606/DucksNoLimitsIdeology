using HarmonyLib;
using RimWorld;
using Verse;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoFoundation), nameof(IdeoFoundation.InitPrecepts))]
public class DucksNoIdeologyLimits_InitPrecepts
{
    public static void Prefix(ref IntRange ___MemeCountRangeAbsolute, IdeoGenerationParms parms)
    {
        if (DucksNoIdeologyLimitsMod.instance.Settings.OnlyPlayer && !parms.forFaction.isPlayer)
        {
            return;
        }

        ___MemeCountRangeAbsolute = new IntRange(0, 1000);
    }
}