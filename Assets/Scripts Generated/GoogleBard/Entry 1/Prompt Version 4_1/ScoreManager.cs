namespace Scripts_Generated.GoogleBard.Prompt_Version_4_1
{
    using UnityEngine;

    public class ScoreManager : MonoBehaviour
    {
        public int score = 0;

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                // Score points
                switch (collision.gameObject.name)
                {
                    case "BigKaboo":
                        score += 480;
                        break;
                    case "Gordow":
                        score += 240;
                        break;
                    case "MummyBall":
                        score += 360;
                        break;
                    case "PeripheralKaboo":
                        if (collision.gameObject.GetComponent<Kaboo>().state == Kaboo.State.Extended)
                            score += 240;
                        else
                            score += 180;
                        break;
                    case "Bumper":
                        score += 50;
                        break;
                    case "Inlane":
                        score += 10;
                        break;
                    case "Outlane":
                        score += 200;
                        break;
                    case "EnergyDrink":
                        score += 100;
                        break;
                }
            }
        }
    }

}