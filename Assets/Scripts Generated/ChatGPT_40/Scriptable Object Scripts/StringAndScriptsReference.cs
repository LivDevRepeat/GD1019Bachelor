namespace Scripts_Generated.ChatGPT_40.Scriptabele_Object_Scripts
{
    using UnityEngine;
    using System.Collections.Generic;

    [CreateAssetMenu(menuName = "PromtAndResponse")]
    public class PromtAndResponse : ScriptableObject
    {
        public TextAsset prompt;
        public List<Response> responses;

        
  
    }

    public enum Model
    {
        GPT3_5,
        GPT4_0,
        GoogleBard
    }
}
