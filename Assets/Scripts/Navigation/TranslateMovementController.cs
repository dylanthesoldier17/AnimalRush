using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class TranslateMovementController : MonoBehaviour, IGameEventListener
{
    public GameEvent changeStateTriggerEvent;
    public enum OnEventAction { NONE, DISABLE, ENABLE, TOGGLE }
    public OnEventAction onEventAction = OnEventAction.NONE;

    public bool enableMovementOnPlayer = true;
    public float speed;
    private bool blockLeft = false;
    private bool blockRight = false;

    private void Start() 
    {
        if(onEventAction != OnEventAction.NONE)
        {
            changeStateTriggerEvent.AddListener(this);
        }
    }

    void Update()
    {
        if(enableMovementOnPlayer)
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

    public void OnEventRaised()
    {
        switch(onEventAction)
        {
            case OnEventAction.ENABLE: enableMovementOnPlayer = true; break;
            case OnEventAction.DISABLE: enableMovementOnPlayer = false; break;
            case OnEventAction.TOGGLE:
                if(enableMovementOnPlayer){
                    enableMovementOnPlayer = false;
                } else {
                    enableMovementOnPlayer = true;
                }
            break;
        }
    }
}
