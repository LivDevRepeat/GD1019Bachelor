using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_3.Prompt_Version_4___Addition
{
    using UnityEngine;

    public class KabooHit : MonoBehaviour {

        private bool retracted = true;

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Ball") {
                if (retracted) {
                    retracted = false;
                    DebugUI.Log("Kaboo retracted!");
                }
            }
        }
    }



}