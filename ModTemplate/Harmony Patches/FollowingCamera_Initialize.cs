using BokuMono;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysFirstMod.Harmony_Patches
{

    [HarmonyPatch(typeof(FollowingCamera), nameof(FollowingCamera.Initialize))]
    internal class FollowingCamera_Initialize
    {
        [HarmonyPostfix]
        internal static void Postfix(FollowingCamera __instance)
        {
            float[] distarray = new float[6] { 21.5f, 18.5f, 15.5f, 12.5f, 9.5f, 7.5f };
            float[] delayarray = new float[6] { 10.0f, 10.0f, 10.0f, 10.0f, 10.0f, 10.0f };
            float[] stiffarray = new float[6] { 4.0f, 4.0f, 4.0f, 4.0f, 4.0f, 4.0f };
            float[] fisharray = new float[6] { 0.0f, 0.0f, 2.0f, 4.0f, 6.0f, 8.0f };
            __instance.distanceArray = distarray;
            __instance.followDelayMaxDistanceArray = delayarray;
            __instance.followDelayStiffnessArray = stiffarray;
            __instance.followDelayFishingStiffnessArray = fisharray;
        }
    }
}
