using System;

namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball
{
    using UnityEngine;

    public class BaseEntity : MonoBehaviour
    {
        public int health = 1; // Default health
        public int points = 10; // Default points

        public virtual void OnHit() 
        {
            health--;

            if(health <= 0)
            {
                OnDefeat();
            }
        }

        protected virtual void OnDefeat()
        {
            ScoringSystem.AddScore(points);
            Destroy(gameObject); // We do not want that
        }

        //Had To Manually Add This
        private void OnCollisionEnter(Collision other)
        {
            OnHit();
        }
        
        private void OnTriggerEnter(Collider other)
        {
            OnHit();
        }
        
    }
}
