using Scripts_Generated.ChatGPT_40.Monobehaviours;

namespace Scripts_Generated.GoogleBard.Prompt_Version_4_1
{
    using UnityEngine;

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