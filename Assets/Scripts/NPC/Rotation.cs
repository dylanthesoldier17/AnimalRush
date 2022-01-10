using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject objectToRotate;
    public Vector3 RotationVector;
    public float rotationSpeed;
    public bool rotationIsEnabled = false;

    private void FixedUpdate()
    {
        if (rotationIsEnabled)
        {
            objectToRotate.transform.Rotate(RotationVector * rotationSpeed * Time.deltaTime);
        }
    }
}
