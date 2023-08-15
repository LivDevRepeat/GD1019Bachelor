using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_2.Prompt_Version_4
{
    public class MummyBall : MonoBehaviour {

        public int hitPoints = 360;
        public int hitPointsToDefeat = 8;

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.tag == "Ball") {
                hitPoints -= 1;
                if (hitPoints <= hitPointsToDefeat) {
                    DebugUI.Log("MummyBall defeated");
                    // Spawn Warp Star
                }
            }
        }
    }
}