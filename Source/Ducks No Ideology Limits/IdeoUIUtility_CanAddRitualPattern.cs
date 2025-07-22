using HarmonyLib;
using RimWorld;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoUIUtility), "CanAddRitualPattern")]
public class IdeoUIUtility_CanAddRitualPattern
{
    public static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}