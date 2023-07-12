// Genrated By Chat GPT 4.0

using System;
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

    private JointSpring spring;

    public InputAction flipperAction;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        
    }

    private void Start()
    {
        spring  = new JointSpring();
        spring.targetPosition = pressedPosition;
    }

    void FixedUpdate()
    {
 
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
