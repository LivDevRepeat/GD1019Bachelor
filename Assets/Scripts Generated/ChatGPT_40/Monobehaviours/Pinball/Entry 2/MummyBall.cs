namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_2
{
    using UnityEngine;

    public class MummyBall : MonoBehaviour
    {
        private int hitCount = 0;
        private const int MaxHits = 8;

        public void OnCollisionEnter(Collision col)
        {
            // Check if collided with Kirby
            if (col.gameObject.CompareTag("Kirby"))
            {
                hitCount++;
                DebugUI.Log("Mummy Ball hit: " + hitCount);
                ScoreManager.AddScore(360);

                if (hitCount >= MaxHits)
                {
                    DebugUI.Log("Mummy Ball defeated!");
                    ScoreManager.AddScore('M'); // Whatever M represents in points
                    // Call Warp Star logic here
                }
            }
        }
    }

}