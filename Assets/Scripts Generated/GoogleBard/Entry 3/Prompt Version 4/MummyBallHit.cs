using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_3.Prompt_Version_4
{
    public class MummyBallHit : MonoBehaviour {

        public int hitCount = 0;

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.tag == "MummyBall") {
                hitCount++;

                if (hitCount == 8) {
                    // Defeat the Mummy Ball and spawn a Warp Star
                    DebugUI.Log("Mummy Ball defeated!");
                    GameObject.Instantiate(Resources.Load("Prefabs/WarpStar"), transform.position, transform.rotation);
                }
            }
        }
    }

}