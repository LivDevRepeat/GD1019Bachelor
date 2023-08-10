using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Prompt_Version_4
{
    public class MummyBall : MonoBehaviour
    {
        public int health = 8;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                health--;
                if (health <= 0)
                {
                    // Defeated!
                    DebugUI.Log("Mummy Ball defeated!");
                    // Spawn a Warp Star
                    //GameObject warpStar = Instantiate(Resources.Load("WarpStar"));  // Lina: This wants to instantiate a Recource that is not real
                   // warpStar.transform.position = transform.position;
                }
            }
        }
    }
}

