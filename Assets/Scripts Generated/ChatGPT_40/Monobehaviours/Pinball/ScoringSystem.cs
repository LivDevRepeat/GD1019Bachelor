using Scripts_Generated.ChatGPT_40.Monobehaviours;

public static class ScoringSystem
{
    private static int score = 0;

    public static void AddScore(int points)
    {
        score += points;
        UpdateUIScore();
    }

    private static void UpdateUIScore()
    {
        // Update your game's UI with the new score here
        DebugUI.Log("Score Updated: " + score);
    }
}