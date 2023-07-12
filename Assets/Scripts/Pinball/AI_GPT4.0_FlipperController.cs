// Genrated By Chat GPT 4.0 // Highly Edited By Hand

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class FlipperController : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    public InputActionReference flipperRaiseAction;
    public InputActionReference flipperLowerAction;

    private JointSpring _spring;

    private HingeJoint hinge;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        _spring = new JointSpring();
        hinge.spring = _spring;
        
        _spring.targetPosition = restPosition;
        _spring.spring = hitStrength ;
        _spring.damper = flipperDamper;

    }

   
    
    void OnEnable()
    {
        flipperRaiseAction.action.performed += SetSpringPressed;
        flipperLowerAction.action.performed += SetSpringLowered;
    }

    void OnDisable()
    {
        flipperRaiseAction.action.performed -= SetSpringPressed;
        flipperLowerAction.action.performed -= SetSpringLowered;

    }
    
    void SetSpringPressed(InputAction.CallbackContext input)
    {
        _spring.targetPosition = pressedPosition;
        hinge.spring = _spring;
    }
    
    void SetSpringLowered(InputAction.CallbackContext input)
    {
        _spring.targetPosition = restPosition;
        hinge.spring = _spring;
    }
}
