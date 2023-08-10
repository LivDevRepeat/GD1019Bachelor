namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_2
{
    using UnityEngine;

    public static class ScoreManager
    {
        private static int score = 0;

        public static void AddScore(int points)
        {
            score += points;
            DebugUI.Log("Score: " + score);
        }
    }

}