// Genrated By Chat GPT 4.0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperController : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    HingeJoint hinge;

    public InputAction flipperAction;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void FixedUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (flipperAction.triggered)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }

    void OnEnable()
    {
        flipperAction.Enable();
    }

    void OnDisable()
    {
        flipperAction.Disable();
    }
}
