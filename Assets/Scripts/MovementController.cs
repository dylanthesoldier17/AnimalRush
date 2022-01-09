using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementController : MonoBehaviour
{
    public GameObject startingPoint;

    private void Awake() 
    {
    //Set start position based on StartingPoint game object.
        transform.position = startingPoint.transform.position;
    }

    private void Update() 
    {
    //Check for user input and move character
           
    }
}
