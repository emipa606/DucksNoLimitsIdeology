﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;
using Verse;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoUIUtility), "DoPreceptsInt")]
public static class DucksNoIdeologyLimits_UIPatch
{
    private static readonly FieldInfo
        maxCountField = AccessTools.Field(typeof(PreceptDef), nameof(PreceptDef.maxCount));

    //private static FieldInfo maxCountFixField = AccessTools.Field(typeof(DucksNoIdeologyLimitsMod), nameof(DucksNoIdeologyLimitsMod.maxCountFix));
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        Log.Message("DUCKS NO IDEOLOGY LIMITS UI PATCH = START");

        var patches = 0;

        var codes = new List<CodeInstruction>(instructions);
        for (var j = 0; j < codes.Count; j++)
        {
            if (codes[j].opcode == OpCodes.Ldfld && codes[j].operand == maxCountField)
            {
                Log.Message("DUCKS NO IDEOLOGY LIMITS UI PATCH = MAX PRECEPT COUNT = FOUND + PATCHED " + j);
                codes[j].opcode = OpCodes.Ldc_I4;
                codes[j].operand = 100;
                patches++;
            }
            else if (codes[j].opcode == OpCodes.Ldstr && codes[j].operand == "MaxRitualCount")
            {
                Log.Message("DUCKS NO IDEOLOGY LIMITS UI PATCH = MAX RITUAL = FOUND STRING " + j);
                for (var i = j; i > j - 30; i--)
                {
                    if (codes[i].opcode != OpCodes.Brfalse_S)
                    {
                        continue;
                    }

                    Log.Message("DUCKS NO IDEOLOGY LIMITS UI PATCH = MAX RITUAL = PATCHED " + i);
                    codes[i - 1].opcode = OpCodes.Nop;
                    codes[i].opcode = OpCodes.Br_S;
                    patches++;
                    break;
                }
            }

            if (patches >= 2)
            {
                break;
            }
        }

        return codes.AsEnumerable();
    }
}