using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball
{
    public class SceneCycler : MonoBehaviour
    {
        public float interval = 20f;
        private int currentSceneIndex;
        private float timer;

        void Start()
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            timer = 0f;
        }

        void Update()
        {
            timer += Time.deltaTime;

            if (timer >= interval)
            {
                timer = 0f;
                LoadNextScene();
            }
        }

        void LoadNextScene()
        {
            currentSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}