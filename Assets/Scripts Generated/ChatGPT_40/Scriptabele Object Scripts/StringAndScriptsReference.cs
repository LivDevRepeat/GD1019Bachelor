namespace Scripts_Generated.ChatGPT_40.Scriptabele_Object_Scripts
{
    using UnityEngine;
    using System.Collections.Generic;

    [CreateAssetMenu(menuName = "ScriptableObjects/StringAndScriptsReference")]
    public class StringAndScriptsReference : ScriptableObject
    {
        public string someString;
        public List<MonoBehaviour> referencedScripts;
    }

}