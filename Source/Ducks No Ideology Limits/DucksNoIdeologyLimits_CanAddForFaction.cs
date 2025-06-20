using HarmonyLib;
using RimWorld;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoFoundation), "CanAddForFaction")]
public class DucksNoIdeologyLimits_CanAddForFaction
{
    public static void Prefix(FactionDef forFaction)
    {
        DucksNoIdeologyLimits.CurrentFactionDef = forFaction;
    }

    public static void Postfix()
    {
        DucksNoIdeologyLimits.CurrentFactionDef = null;
    }
}