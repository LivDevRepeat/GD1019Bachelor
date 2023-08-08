using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

// Genrated By Chat GPT 4.0 
public class SceneLoader : MonoBehaviour
{
    // singleton instance
    public static SceneLoader Instance { get; private set; }

    // prevent duplication of instance
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // method to load scene
    public void LoadScene(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //string sceneName = context.ReadValue<string>();
            SceneManager.LoadScene(1);
        }
    }

    // method to reload the current scene
    public void ReloadCurrentScene(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }

    // method to quit the application
    public void QuitGame(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Application.Quit();
        }
    }
}