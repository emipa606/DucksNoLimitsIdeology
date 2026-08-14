using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;

namespace DucksNoIdeologyLimits;

[HarmonyPatch(typeof(IdeoUIUtility), "AddPrecept")]
public static class IdeoUIUtility_AddPrecept
{
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);

        for (var i = 0; i < codes.Count; i++)
        {
            // Look for ldc.i4.6 followed by comparison operations (bge, bge.s, etc.)
            if (codes[i].opcode != OpCodes.Ldc_I4_6)
            {
                continue;
            }

            if (i + 1 >= codes.Count)
            {
                continue;
            }

            var nextOpcode = codes[i + 1].opcode;

            if (nextOpcode != OpCodes.Bge && nextOpcode != OpCodes.Bge_S &&
                nextOpcode != OpCodes.Bge_Un && nextOpcode != OpCodes.Bge_Un_S)
            {
                continue;
            }

            // Replace the hardcoded limit of 6 with 1000
            codes[i].opcode = OpCodes.Ldc_I4;
            codes[i].operand = 1000;
        }

        return codes.AsEnumerable();
    }
}