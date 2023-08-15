using Scripts_Generated.ChatGPT_40.Monobehaviours;
using UnityEngine;

namespace Scripts_Generated.GoogleBard.Entry_3.Prompt_Version_4
{
    public class Launcher : MonoBehaviour {

        public enum Direction {
            Up,
            Down,
            Left,
            Right
        }

        private Direction direction;

        private void OnCollisionEnter2D(Collision2D collision) {
            if (collision.gameObject.tag == "Ball") {
                direction = (Direction)Random.Range(0, 4);
                DebugUI.Log("Launching Kirby in direction " + direction.ToString());

                // Launch the ball in the specified direction
                Vector2 launchVelocity = Vector2.zero;
                switch (direction) {
                    case Direction.Up:
                        launchVelocity = new Vector2(0, 100);
                        break;
                    case Direction.Down:
                        launchVelocity = new Vector2(0, -100);
                        break;
                    case Direction.Left:
                        launchVelocity = new Vector2(-100, 0);
                        break;
                    case Direction.Right:
                        launchVelocity = new Vector2(100, 0);
                        break;
                }

              //  ball.GetComponent<Rigidbody2D>().AddForce(launchVelocity); // [Manual Fix] ball is not defined
            }
        }
    }
   
}