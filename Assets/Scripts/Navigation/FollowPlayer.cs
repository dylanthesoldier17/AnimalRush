using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public CameraPositions[] cameraPositions;
    public int positionIndex = 0;

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = player.transform.position + cameraPositions[positionIndex].position;
        transform.localEulerAngles = cameraPositions[positionIndex].rotation;
    }

    public void loadNextPosition()
    {
        if(positionIndex+1 >= cameraPositions.Length)
        {
            positionIndex = 0;
        } else {
            ++positionIndex;
        }
    }

    public void loadPreviousPosition()
    {
        if(positionIndex-1 < 0)
        {
            positionIndex = cameraPositions.Length-1;
        } else {
            --positionIndex;
        }
    }

    public void loadPosition(int i)
    {
        positionIndex = i;
    }
}
