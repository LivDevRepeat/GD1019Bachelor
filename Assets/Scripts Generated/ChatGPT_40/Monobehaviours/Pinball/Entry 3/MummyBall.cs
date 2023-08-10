namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_3
{
    using UnityEngine;

    public class MummyBall : FlipperObject
    {
        private int hitCount = 0;

        public override void Hit()
        {
            base.Hit();
            hitCount++;

            if (hitCount >= 8)
            {
                DebugUI.Log("Mummy Ball defeated! Warp Star Called!");
                GameManager.instance.AddScore(360); // Bonus score for defeating Mummy Ball
                // Call Warp Star logic here
            }
        }
    }

}