using BepInEx;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace MaeLand4
{
    [BepInPlugin("com.archiverxp.maeland4", "Mae Land 4", "1.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"com.archiverxp.maeland4"} is loaded!");
            SceneManager.LoadScene("TowneCentreWest");
            var harmony = new Harmony("com.archiverxp.maeland4");
            harmony.PatchAll();
        }
    }
}
