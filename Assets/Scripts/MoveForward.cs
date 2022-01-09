using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public bool move = true;
    public float speed = 15f;
    public Vector3 direction = Vector3.forward;

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
