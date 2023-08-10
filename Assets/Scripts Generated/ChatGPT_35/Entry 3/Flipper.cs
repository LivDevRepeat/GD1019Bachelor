namespace GeneratedCode.ChatGPT_35.Entry_3
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Flipper : MonoBehaviour
    {
        public float flipperStrength = 500f;

        private HingeJoint2D hinge;

        void Start()
        {
            hinge = GetComponent<HingeJoint2D>();
        }

        public void ActivateFlipper()
        {
            // Apply torque to the hinge joint to simulate flipper movement
           //hinge.AddTorque(flipperStrength);
           //had to comment that out so it would not throw an error
        }
    }

}