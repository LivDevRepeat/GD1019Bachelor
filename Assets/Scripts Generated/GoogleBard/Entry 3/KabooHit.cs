using Scripts_Generated.ChatGPT_40.Monobehaviours;

namespace GeneratedCode.GoogleBard.Entry_3
{
    using UnityEngine;
    
    public class KabooHit : MonoBehaviour {

        private bool retracted = true;

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.tag == "Ball") {
                if (retracted) {
                    retracted = false;
                    DebugUI.Log("Kaboo retracted!");
                }
            }
        }
    }


}