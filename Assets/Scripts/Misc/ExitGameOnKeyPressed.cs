using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameOnKeyPressed : MonoBehaviour
{
    public KeyCode key;
    private int keyPressedCount;
    public float keyPressedTimeoutInSeconds = 2;
    public int keyPressCountToActivate = 2;

    private void Start()
    {
        InvokeRepeating("resetKeyPressedCounter", 0, keyPressedTimeoutInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        incrementCounter();
    }

    private void incrementCounter()
    {
        // inrement key pressed counter if key is pressed
        if (Input.GetKeyDown(key))
        {
            keyPressedCount++;
        }

        // if threshold is reached the exit
        if (keyPressedCount >= keyPressCountToActivate)
        {
            ExitGame();
        }
    }

    private void resetKeyPressedCounter()
    {
        keyPressedCount = 0;
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }
    
    public void exitGameDelayedInSeconds(int delayInSeconds)
    {
        Invoke(nameof(ExitGame), delayInSeconds);
    }
}
