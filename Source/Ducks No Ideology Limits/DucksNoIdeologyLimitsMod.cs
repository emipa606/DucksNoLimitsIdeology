using System.Reflection;
using HarmonyLib;
using Verse;

namespace DucksNoIdeologyLimits;

[StaticConstructorOnStartup]
public static class DucksNoIdeologyLimits
{
    static DucksNoIdeologyLimits()
    {
        new Harmony("net.ducks.rimworld.mod.ducksnoideologylimits").PatchAll(Assembly.GetExecutingAssembly());
    }
}