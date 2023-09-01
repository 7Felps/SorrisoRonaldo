using OWML.Common;
using OWML.ModHelper;

namespace SorrisoRonaldo
{
    public class SorrisoRonaldo : ModBehaviour
    {
        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(SorrisoRonaldo)} is loaded!", MessageType.Success);


            // Example of accessing game code.
            LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
            {
                var SorrisoRonaldo = ModHelper.Assets.GetAudio("SorrisoRonaldo.mp3");

                ModHelper.Events.Unity.FireInNUpdates(() =>
                {
                    var audioTable = Locator.GetAudioManager()._audioLibraryDict;
                    audioTable[(int)AudioType.Flashback_Base_LP] = new AudioLibrary.AudioEntry(AudioType.EndOfTime, new[] { SorrisoRonaldo });

                    ModHelper.Console.WriteLine("É o Sorriso Ronaldo que chegou!");

                }, 10);
            };
        }
    }
}