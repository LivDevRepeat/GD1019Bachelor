using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ExitTrigger : MonoBehaviour
{
    public UnityEvent exitTriggerEvent;

    private void Awake()
    {
        exitTriggerEvent.AddListener( DebugMessage);
    }

    private void DebugMessage()
    {
        Debug.Log("Object has exited the trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        if(exitTriggerEvent != null) exitTriggerEvent.Invoke();
    }
}
