using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_2.Prompt_Version_4___Addition
{
    public class WarpStar : MonoBehaviour {

        public void OnTriggerEnter(Collider collision) {
            if (collision.gameObject.tag == "Ball") {
                DebugUI.Log("Warp Star activated");
                // Teleport Kirby to next board
            }
        }
    }
}