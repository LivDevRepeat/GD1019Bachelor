using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_3.Prompt_Version_4
{
    public class KirbyTriplet : MonoBehaviour {

        public enum State {
            Sleeping,
            WakingUp,
            FullyAwake
        }

        private State state = State.Sleeping;

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.tag == "Ball") {
                switch (state) {
                    case State.Sleeping:
                        state = State.WakingUp;
                        DebugUI.Log("Kirby Triplet waking up!");
                        break;
                    case State.WakingUp:
                        state = State.FullyAwake;
                        DebugUI.Log("Kirby Triplet fully awake!");
                        break;
                    case State.FullyAwake:
                        break;
                }
            }
        }
    }

}