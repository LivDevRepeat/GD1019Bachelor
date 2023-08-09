using Scripts_Generated.ChatGPT_40.Monobehaviours;
using Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball;
using UnityEngine;
public class MummyBall : BaseEntity
{
    public int hitCountToDefeat = 8;
    public int bonusScoreWhenDefeated = 1000;

    void Start() 
    {
        health = hitCountToDefeat;
        points = 360;
    }

    protected override void OnDefeat()
    {
        ScoringSystem.AddScore(points + bonusScoreWhenDefeated);
        // Call Warp Star logic here
        DebugUI.Log("Warp Star called.");
        base.OnDefeat();
    }
}

