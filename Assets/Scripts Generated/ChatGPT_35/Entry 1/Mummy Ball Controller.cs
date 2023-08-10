using Scripts_Generated.ChatGPT_40.Monobehaviours;

namespace GeneratedCode.ChatGPT_35
{
    using UnityEngine;

    public class MummyBallController : MonoBehaviour
    {
        public int hitsToDefeat = 8;
        private int currentHits = 0;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Flipper"))
            {
                currentHits++;
                if (currentHits >= hitsToDefeat)
                {
                    // Defeat logic here
                    DebugUI.Log("Mummy Ball defeated!");
                }
            }
        }
    }

}