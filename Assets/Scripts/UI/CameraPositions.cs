using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Camera_Position", menuName = "Project/Camera/Camera Position", order = 0)]
public class CameraPositions : ScriptableObject 
{
    public Vector3 position;
    public Vector3 rotation;
}