using HarmonyLib;
using System;
using System.Reflection;
using UnityEngine;

namespace FlappyMae.HarmonyPatches
{
    [HarmonyPatch]
    class Patch
    {
        static MethodBase TargetMethod()
        {
            return AccessTools.Method(typeof(Player), "Update");
        }

        static void Prefix(ref Player __instance)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                __instance.runSpeedOverride = 8.25f;
                __instance.transform.localScale = new Vector3(1, 0.8473f, 1);
                __instance.runAccel = 100.0f;



            }
            else if (Input.GetKeyUp(KeyCode.V))
            {
                __instance.runSpeedOverride = 4.25f;
                __instance.transform.localScale = new Vector3(1, 1, 1);
                __instance.runAccel = 15.0f;
            }
        }
    }
}
