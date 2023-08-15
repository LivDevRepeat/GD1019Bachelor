using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_2.Prompt_Version_4___Addition
{
    public class PeripheralKaboo : MonoBehaviour {

        public int hitPoints = 240;
        public bool retracted = true;

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Ball") {
                if (retracted) {
                    retracted = false;
                    DebugUI.Log("Peripheral Kaboo retracted");
                } else {
                    hitPoints -= 1;
                    if (hitPoints <= 0) {
                        DebugUI.Log("Peripheral Kaboo destroyed");
                        Destroy(this);
                    }
                }
            }
        }
    }
}