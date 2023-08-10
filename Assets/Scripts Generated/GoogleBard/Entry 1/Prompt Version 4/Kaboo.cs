using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Prompt_Version_4
{
    public class Kaboo : MonoBehaviour
    {
        public enum State { Extended, Retracted }

        public State state = State.Extended;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                if (state == State.Extended)
                {
                    state = State.Retracted;
                    DebugUI.Log("Kaboo retracted.");
                }
            }
        }
    }

}