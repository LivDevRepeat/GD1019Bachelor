using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_3.Prompt_Version_4___Addition
{
    using UnityEngine;

    public class Launcher : MonoBehaviour {

        public enum Direction {
            Up,
            Down,
            Left,
            Right
        }

        private Direction direction;

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Ball") {
                direction = (Direction)Random.Range(0, 4);
                DebugUI.Log("Launching Kirby in direction " + direction.ToString());

                // Launch the ball in the specified direction
                Vector3 launchVelocity = Vector3.zero;
                switch (direction) {
                    case Direction.Up:
                        launchVelocity = new Vector3(0, 100, 0);
                        break;
                    case Direction.Down:
                        launchVelocity = new Vector3(0, -100, 0);
                        break;
                    case Direction.Left:
                        launchVelocity = new Vector3(-100, 0, 0);
                        break;
                    case Direction.Right:
                        launchVelocity = new Vector3(100, 0, 0);
                        break;
                }

                // ball.GetComponent<Rigidbody>().AddForce(launchVelocity); // [Manual Fix] ball is not defined
            }
        }
    }

   
}