using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace GeneratedCode.GoogleBard.Entry_2
{
    public class Kaboo : MonoBehaviour {

        public int hitPoints = 240;

        private void OnCollisionEnter2D(Collision2D collision) {
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