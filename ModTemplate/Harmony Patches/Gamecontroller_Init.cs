using BokuMono;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysFirstMod.Harmony_Patches
{

    [HarmonyPatch(typeof(GameController), nameof(GameController.Init))]
    internal class GameController_Init
    {
        [HarmonyPostfix]
        internal static void Postfix(GameController __instance)
        {
            __instance.GameSetting.FieldObjectClipPadding = 3.0f;
            __instance.GameSetting.FieldObjectFarClip = 50.0f;
            __instance.GameSetting.FieldObjectSubtractedFarClip = 0.0f;
            __instance.GameSetting.FieldObjectFarClipLimit = 2.0f;
            __instance.GameSetting.FieldObjectFarClipSpeed = 0.2f;
        }
    }
}