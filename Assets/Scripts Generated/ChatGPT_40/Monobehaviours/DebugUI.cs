using System;

namespace Scripts_Generated.ChatGPT_40.Monobehaviours
{
    using UnityEngine;
    using UnityEngine.UI; // For basic UI elements like ScrollRect
    using TMPro; // Use if you're using TextMeshPro

    public class DebugUI : MonoBehaviour
    {
        // For UI.Text (Uncomment if you're using this instead of TextMeshPro)
        // public Text debugText;

        // For TextMeshPro (Uncomment if you're using TextMeshPro)
        public TMP_Text debugText;

        public ScrollRect scrollRect;

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
            DebugUI.Log("DebugUI initialized");
        }

        
        public static void Log(string message)
        {
            if (instance == null)
            {
                Debug.LogWarning("DebugUI instance not found!");
                return;
            }

            instance.debugText.text += message + "\n";

            // Auto-scroll to show the newest message
            Canvas.ForceUpdateCanvases();  // Force all UI elements to update
            instance.scrollRect.verticalNormalizedPosition = 0f;  // Scroll to bottom
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