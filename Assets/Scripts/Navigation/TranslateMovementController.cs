using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMovementController : MonoBehaviour
{
    public bool enableMovementOnPlayer = true;
    public float speed;
    private bool blockLeft = false;
    private bool blockRight = false;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && blockLeft != true)
        {
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && blockRight != true)
        {
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "LeftBorder")
        {
            blockLeft = true;
        }
        else if (other.name == "RightBorder")
        {
            blockRight = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.name == "LeftBorder")
        {
            blockLeft = false;
        }
        else if (other.name == "RightBorder")
        {
            blockRight = false;
        }
    }

    public void enableMovement()
    {
        enableMovementOnPlayer = true;
    }

    public void disableMovement()
    {
        enableMovementOnPlayer = false;
    }
}
