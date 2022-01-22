using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnLoad : MonoBehaviour
{
    public bool onRuntime = true;
    private void Awake()
    {
        if (onRuntime)
        {
            gameObject.SetActive(false);
        }
    }
}
