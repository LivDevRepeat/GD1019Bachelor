namespace GeneratedCode.ChatGPT_35
{
    using UnityEngine;
    using UnityEngine.Events;
    public class PinballGame : MonoBehaviour
    {
        // Life variable that can be edited in the editor
        [SerializeField] private int life = 3;

        // Unity events to be triggered when life changes
        public UnityEvent lifeIncreaseEvent;
        public UnityEvent lifeDecreaseEvent;
        public UnityEvent gameOverEvent;

        private void Awake()
        {
            // Subscribe functions to the Unity events on Awake
            lifeIncreaseEvent.AddListener(IncreaseLife);
            lifeDecreaseEvent.AddListener(DecreaseLife);
            gameOverEvent.AddListener(GameOver);
        }

        // Function to increase life variable by one
        private void IncreaseLife()
        {
            life++;
            Debug.Log("Life increased. Current life: " + life);
        }

        // Function to decrease life variable and check if it's zero, then call game over function
        private void DecreaseLife()
        {
            life--;
            Debug.Log("Life decreased. Current life: " + life);

            if (life <= 0)
            {
                // Trigger the game over event
                gameOverEvent.Invoke();
            }
        }

        // Function to handle game over
        private void GameOver()
        {
            Debug.Log("Game Over");
            // You can add any additional game over logic here, like displaying a game over screen or restarting the level.
        }
    }
}
