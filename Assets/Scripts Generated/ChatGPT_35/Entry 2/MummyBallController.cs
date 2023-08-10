using Scripts_Generated.ChatGPT_40.Monobehaviours;

namespace GeneratedCode.ChatGPT_35.Entry_2
{
    // MummyBallController.cs
    using UnityEngine;

    public class MummyBallController : MonoBehaviour
    {
        public int mummyHitPoints = 8;
        private int currentHitPoints = 0;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                currentHitPoints++;
                if (currentHitPoints >= mummyHitPoints)
                {
                    // Call a function to defeat the Mummy Ball
                    DefeatMummyBall();
                }
            }
        }

        private void DefeatMummyBall()
        {
            // Perform actions to defeat the Mummy Ball
            // Spawn Warp Star, update score, etc.
            //ScoreManager.Instance.AddScore(360);
            DebugUI.Log("Mummy Ball defeated!");
        }
    }

}