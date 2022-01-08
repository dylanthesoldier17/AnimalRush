using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaryEngine : MonoBehaviour
{
    public bool engineIsOn = true;
    public float topRotorRotationSpeed = 0;
    public float backRotorRotationSpeed = 0;
    public GameObject topRotor;
    public GameObject backRotor;

    // Update is called once per frame
    private void FixedUpdate()
    {
        {
            if (engineIsOn)
            {
                topRotor.gameObject.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * topRotorRotationSpeed);
                backRotor.gameObject.transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * backRotorRotationSpeed);
            }
        }
    }
}