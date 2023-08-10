using Scripts_Generated.GoogleBard.Prompt_Version_4;

namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_2
{
    using UnityEngine;

    public class Kaboo : MonoBehaviour
    {
        private bool isBigKaboo;
        private bool isRetracted = false;

        void Start()
        {
            // Check if it's Big Kaboo
            isBigKaboo = gameObject.name == "BigKaboo"; // or some other logic to determine
        }

        public void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.CompareTag("Kirby"))
            {
                if (isBigKaboo)
                {
                    ScoreManager.AddScore(480);
                }
                else
                {
                    ScoreManager.AddScore(isRetracted ? 180 : 240);
                    if (!isRetracted)
                    {
                        isRetracted = true;
                        // Change the sprite or model to retracted state
                    }
                }
            }
        }
    }

}