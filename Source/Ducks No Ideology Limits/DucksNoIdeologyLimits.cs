using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace DucksNoIdeologyLimits;

[StaticConstructorOnStartup]
public static class DucksNoIdeologyLimits
{
    public static FactionDef CurrentFactionDef = null;

    static DucksNoIdeologyLimits()
    {
        new Harmony("net.ducks.rimworld.mod.ducksnoideologylimits").PatchAll(Assembly.GetExecutingAssembly());
        foreach (var precept in DefDatabase<PreceptDef>.AllDefs)
        {
            precept.ignoreLimitsInEditMode = true;
        }
    }
}