namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_3
{
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        public static GameManager instance; // Singleton pattern

        public int score = 0; // The player's score

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddScore(int value)
        {
            score += value;
            DebugUI.Log($"Score: {score}");
        }
    }

}