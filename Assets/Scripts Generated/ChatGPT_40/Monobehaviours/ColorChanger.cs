namespace Scripts_Generated.ChatGPT_40.Monobehaviours
{
    using System.Collections;
    using UnityEngine;

    [RequireComponent(typeof(Renderer))]
    public class ColorChanger : MonoBehaviour
    {
        public Color triggerColor = Color.red;
        public Color collisionColor = Color.blue;
        public float duration = 2.0f; // Duration for which the color will be changed, editable in inspector

        private Renderer rend;
        private Color originalColor;

        void Start()
        {
            rend = GetComponent<Renderer>();
            originalColor = rend.material.color;
        }

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(ChangeColorTemporarily(triggerColor));
        }

        private void OnCollisionEnter(Collision collision)
        {
            StartCoroutine(ChangeColorTemporarily(collisionColor));
        }

        IEnumerator ChangeColorTemporarily(Color newColor)
        {
            rend.material.color = newColor;
            yield return new WaitForSeconds(duration);
            rend.material.color = originalColor;
        }
    }

}