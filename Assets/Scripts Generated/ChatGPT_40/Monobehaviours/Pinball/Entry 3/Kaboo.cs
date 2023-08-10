namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_3
{
    using UnityEngine;

    public class Kaboo : FlipperObject
    {
        public bool isRetracted = false;

        public override void Hit()
        {
            if (!isRetracted)
            {
                isRetracted = true;
                hitScore = 180; // Update score for subsequent hits
            }
        
            base.Hit();
        
            // Check if all Kaboos are retracted to reveal the Big Kaboo star launcher
        }
    }

}