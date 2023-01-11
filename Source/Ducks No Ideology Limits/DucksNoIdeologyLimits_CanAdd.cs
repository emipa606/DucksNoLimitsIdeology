using HarmonyLib;
using RimWorld;
using Verse;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoFoundation))]
[HarmonyPatch("CanAdd")]
public class DucksNoIdeologyLimits_CanAdd
{
    public static bool Prefix(ref AcceptanceReport __result, IdeoFoundation __instance, ref PreceptDef precept,
        ref bool checkDuplicates)
    {
        var preceptsListForReading = __instance.ideo.PreceptsListForReading;
        if (precept.takeNameFrom != null)
        {
            var takeNameFrom = false;
            using (var enumerator = __instance.ideo.PreceptsListForReading.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current?.def != precept.takeNameFrom)
                    {
                        continue;
                    }

                    takeNameFrom = true;
                    break;
                }
            }

            if (!takeNameFrom)
            {
                __result = false;
                return false;
            }
        }

        foreach (var preceptToTest in preceptsListForReading)
        {
            if (!checkDuplicates)
            {
                continue;
            }

            if (precept == preceptToTest.def)
            {
                if (precept.allowDuplicates)
                {
                    continue;
                }

                __result = false;
                return false;
            }

            if (precept.issue.allowMultiplePrecepts || precept.issue != preceptToTest.def.issue)
            {
                continue;
            }

            __result = false;
            return false;
        }

        __result = true;
        return false;
    }
}