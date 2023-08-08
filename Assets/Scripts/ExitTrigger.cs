using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ExitTrigger : MonoBehaviour
{
    [System.Serializable]
    public class GameObjectEvent : UnityEvent<GameObject> { }

    public GameObjectEvent exitTriggerEvent;

    private void Awake()
    {
        exitTriggerEvent.AddListener(DebugMessage);
    }

    private void DebugMessage(GameObject obj)
    {
        Debug.Log(obj.name + " has exited the trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        if(exitTriggerEvent != null) exitTriggerEvent.Invoke(other.gameObject);
    }
}