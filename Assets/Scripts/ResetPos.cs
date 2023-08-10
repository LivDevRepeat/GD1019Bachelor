using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    private Vector3 startpos;

    private void Awake()
    {
        startpos = transform.position;
    }
    
    public void ResetPosition()
    {
        transform.position = startpos;
    }
}
