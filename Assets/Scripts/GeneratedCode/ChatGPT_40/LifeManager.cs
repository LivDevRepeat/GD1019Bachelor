namespace GeneratedCode.ChatGPT_40
{
    using UnityEngine;
    using UnityEngine.Events;

    public class LifeManager : MonoBehaviour
    {
        [SerializeField]
        private int life = 3; // Default life count, can be edited in the editor
        public UnityEvent onLifeIncrease;
        public UnityEvent onLifeDecrease;
        public UnityEvent onGameOver;

        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            // Subscribe the functions to the respective Unity Events
            onLifeIncrease.AddListener(IncreaseLife);
            onLifeDecrease.AddListener(DecreaseLife);
            onGameOver.AddListener(GameOver);
        }

        // Function that increases life variable by one
        public void IncreaseLife()
        {
            life++;
            Debug.Log("Life Increased: " + life);
        }

        // Function that decreases life variable and checks if it's zero
        // If it is, it will call the game over function
        public void DecreaseLife()
        {
            life--;
            Debug.Log("Life Decreased: " + life);

            if (life <= 0)
            {
                onGameOver.Invoke(); // Invoking the GameOver event
            }
        }

        // Function that handles the Game Over logic
        public void GameOver()
        {
            Debug.Log("Game Over!");
            // You can add further game over logic here, such as transitioning to a Game Over screen
        }
    }

    
}
