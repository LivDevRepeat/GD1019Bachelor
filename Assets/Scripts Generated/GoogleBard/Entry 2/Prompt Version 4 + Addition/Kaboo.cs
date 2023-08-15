using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_2.Prompt_Version_4___Addition
{
    public class Kaboo : MonoBehaviour {

        public int hitPoints = 240;

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Ball") {
                hitPoints -= 1;
                if (hitPoints <= 0) {
                    DebugUI.Log("Kaboo destroyed");
                    Destroy(this);
                }
            }
        }
    }
}