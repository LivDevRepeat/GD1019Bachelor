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

    public InputActionReference flipperAction;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        spring = new JointSpring();
        hinge.spring = spring;

    }

   public void SetSpringValue(InputAction.CallbackContext input)
    {
        spring.targetPosition = 30;
        Debug.Log(input.action.name);

    }



    void OnEnable()
    {
        flipperAction.action.performed += SetSpringValue;
    }

    void OnDisable()
    {
        flipperAction.action.performed -= SetSpringValue;
    }
}
