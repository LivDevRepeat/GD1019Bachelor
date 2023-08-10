using System;

namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_3
{
    using UnityEngine;

    public class FlipperObject : MonoBehaviour
    {
        public int hitScore; // Score when the object is hit

        public virtual void Hit()
        {
            GameManager.instance.AddScore(hitScore);
        }

        
        //Had to add that for it to work
        private void OnCollisionEnter(Collision other)
        {
            Hit();
        }
    }


}