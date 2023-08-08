using UnityEngine;

namespace Scripts_Generated.ChatGPT_40.Scriptabele_Object_Scripts
{
    [CreateAssetMenu(menuName = "Create Response", fileName = "Response", order = 0)]
    public class Response : ScriptableObject
    {

        public Model model;
        public TextAsset response;
        public TextAsset script;

    }
}