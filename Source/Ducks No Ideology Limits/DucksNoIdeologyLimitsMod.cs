using HarmonyLib;
using Verse;

namespace DucksNoIdeologyLimits;

[StaticConstructorOnStartup]
public class DucksNoIdeologyLimits
{
    public DucksNoIdeologyLimits()
    {
        new Harmony("net.ducks.rimworld.mod.ducksnoideologylimits").PatchAll();
    }
}