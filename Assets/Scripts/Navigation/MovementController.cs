using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public LinkedPath location;

    private void Awake()
    {
        //Set start position based on location game object.
        navMeshAgent.Warp(location.transform.position);
    }

    private void Update()
    {
        //Don't do anything if player is navigating to the destination
        if (navMeshAgent.pathStatus != NavMeshPathStatus.PathComplete) { return; }

        //Check for user input and move character
        CheckInputAndSetLocation(KeyCode.UpArrow, location.Up);
        CheckInputAndSetLocation(KeyCode.LeftArrow, location.Left);
        CheckInputAndSetLocation(KeyCode.RightArrow, location.Right);
        CheckInputAndSetLocation(KeyCode.DownArrow, location.Down);
    }

    private void CheckInputAndSetLocation(KeyCode keyCode, LinkedPath selectedLocation)
    {
        if (Input.GetKeyDown(keyCode) && selectedLocation != null)
        {
            location = selectedLocation;
            navMeshAgent.SetDestination(location.transform.position);
        }
    }
}
