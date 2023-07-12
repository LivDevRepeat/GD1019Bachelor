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
    public InputActionReference flipperAction;
    

    private JointSpring _spring;

    private HingeJoint hinge;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        _spring = new JointSpring();
        hinge.spring = _spring;
        _spring.targetPosition = 30;

    }

   
    
    void OnEnable()
    {
        flipperAction.action.performed += SetSpringValue;
    }

    void OnDisable()
    {
        flipperAction.action.performed -= SetSpringValue;
    }
    
    void SetSpringValue(InputAction.CallbackContext input)
    {
        _spring.spring = 1 ;
        _spring.targetPosition = 30;
        hinge.spring = _spring;
        Debug.Log(input.action.name);

    }
}
