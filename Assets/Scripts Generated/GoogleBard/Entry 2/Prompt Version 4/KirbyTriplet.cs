using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_2.Prompt_Version_4
{
    public class KirbyTriplet : MonoBehaviour {

    public int awakeState = 0; // 0 = asleep, 1 = awake, 2 = fully down

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ball") {
            awakeState = (awakeState + 1) % 3;
            if (awakeState == 2) {
                DebugUI.Log("Maxim Tomato spawned");
                // Spawn Maxim Tomato
            }
        }
    }
}
}