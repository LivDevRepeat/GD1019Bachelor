using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Prompt_Version_4
{
    public class KirbyTriplet : MonoBehaviour
    {
        public enum State { Awake, Sleeping, Down }

        public State state = State.Awake;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                switch (state)
                {
                    case State.Awake:
                        state = State.Sleeping;
                        DebugUI.Log("Kirby Triplet is now sleeping.");
                        break;
                    case State.Sleeping:
                        state = State.Down;
                        DebugUI.Log("Kirby Triplet is now down.");
                        break;
                    case State.Down:
                        // Do nothing
                        break;
                }
            }
        }
    }

}