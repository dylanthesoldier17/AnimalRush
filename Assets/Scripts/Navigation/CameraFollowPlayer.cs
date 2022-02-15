using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public CameraPositions[] cameraPositions;
    public int positionIndex = 0;
    
    private void LateUpdate()
    {
        var transform1 = transform;
        transform1.position = player.transform.position + cameraPositions[positionIndex].position;
        transform1.localEulerAngles = cameraPositions[positionIndex].rotation;
    }

    public void LoadNextPosition()
    {
        if(positionIndex+1 >= cameraPositions.Length)
        {
            positionIndex = 0;
        } else {
            ++positionIndex;
        }
    }

    public void LoadPreviousPosition()
    {
        if(positionIndex-1 < 0)
        {
            positionIndex = cameraPositions.Length-1;
        } else {
            --positionIndex;
        }
    }

    public void LoadPosition(int i)
    {
        positionIndex = i;
    }
}
