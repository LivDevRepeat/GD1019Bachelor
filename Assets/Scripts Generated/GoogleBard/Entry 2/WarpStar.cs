using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace GeneratedCode.GoogleBard.Entry_2
{
    public class WarpStar : MonoBehaviour {

        public void OnTriggerEnter2D(Collider2D collision) {
            if (collision.gameObject.tag == "Ball") {
                DebugUI.Log("Warp Star activated");
                // Teleport Kirby to next board
            }
        }
    }
}