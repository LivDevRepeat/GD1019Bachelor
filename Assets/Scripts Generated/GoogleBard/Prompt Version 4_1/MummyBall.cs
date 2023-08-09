using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Prompt_Version_4_1
{
    public class MummyBall : MonoBehaviour
    {
        public int health = 8;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<BallController>())
            {
                health--;
                if (health <= 0)
                {
                    // Defeated!
                    DebugUI.Log("Mummy Ball defeated!");
                }
            }
        }
    }

}