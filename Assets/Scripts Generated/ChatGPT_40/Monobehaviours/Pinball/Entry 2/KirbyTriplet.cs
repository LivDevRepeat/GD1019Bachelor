namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball.Entry_2
{
    using UnityEngine;

    public class KirbyTriplet : MonoBehaviour
    {
        private enum Expression { Awake, Middle, Down }
        private Expression currentExpression = Expression.Middle;
    
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Kirby"))
            {
                ChangeExpression();
            }
        }

        private void ChangeExpression()
        {
            if (currentExpression == Expression.Middle)
            {
                currentExpression = Expression.Awake;
                // Change sprite to awake expression
            }
            else if (currentExpression == Expression.Awake)
            {
                currentExpression = Expression.Down;
                // Change sprite to down expression
                // Check if all are down, remove stoppers
            }
            // Add other logics like Maxim Tomato appearing, etc.
        }
    }

}