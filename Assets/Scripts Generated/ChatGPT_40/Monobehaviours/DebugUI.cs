namespace Scripts_Generated.ChatGPT_40.Monobehaviours
{using UnityEngine;
    using UnityEngine.UI; // Use this for the basic UI.Text
    using TMPro; // Use this if you're using TextMeshPro

    public class DebugUI : MonoBehaviour
    {
        // For UI.Text
        // public Text debugText;

        // For TextMeshPro
        public TMP_Text debugText;

        private static DebugUI instance;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public static void Log(string message)
        {
            if (instance == null)
            {
                Debug.LogWarning("DebugUI instance not found!");
                return;
            }

            instance.debugText.text += message + "\n";

            // Scroll the debug log to the bottom so the latest message is always visible
            Canvas.ForceUpdateCanvases(); // Update the canvas immediately
            instance.GetComponentInParent<ScrollRect>().verticalNormalizedPosition = 0f;
        }

        public static void Clear()
        {
            if (instance == null)
            {
                Debug.LogWarning("DebugUI instance not found!");
                return;
            }

            instance.debugText.text = "";
        }
    }

}