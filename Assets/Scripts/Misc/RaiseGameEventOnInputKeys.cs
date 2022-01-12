using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseGameEventOnInputKeys : MonoBehaviour
{
    public bool enableEvents = true;
    public enum keyAction { NONE, ON_KEY, ON_KEY_PRESSED, ON_KEY_UP }
    public keyAction selectKeyAction = keyAction.NONE;
    public KeyCode selectKeyCode;
    public IntGameEvent gameEvent;

    private void Update()
    {
        if (Input.anyKeyDown && selectKeyAction != keyAction.ON_KEY_UP)
        {
            if (Input.anyKey)
            {
                onKey(ref selectKeyCode);
            }
            else if (Input.anyKeyDown)
            {
                onKeyPressed(ref selectKeyCode);
            }
        }

        if (selectKeyAction == keyAction.ON_KEY_UP)
        {
            if (Input.GetKeyUp(selectKeyCode))
            {
                raiseEvent(ref selectKeyCode);
            }
        }
    }

    private void raiseEvent(ref KeyCode keyCode)
    {
        gameEvent?.Raise(((int)keyCode));

        /**/
        #if UNITY_EDITOR
            Debug.Log("Key Pressed or Release!");
        #endif 
        /**/
    }

    private void onKey(ref KeyCode keyCode)
    {
        if (Input.GetKey(keyCode))
        {
            raiseEvent(ref keyCode);
        }
    }

    private void onKeyPressed(ref KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            raiseEvent(ref keyCode);
        }
    }

    private void onKeyUp(ref KeyCode keyCode)
    {
        if (Input.GetKeyUp(keyCode))
        {
            raiseEvent(ref keyCode);
        }
    }
}
