using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "LinkedPathItem", menuName = "Paths/LinkedPath", order = 0)]
public class LinkedPath : MonoBehaviour 
{
    [field: SerializeField] private GameObject Up { get; set; }
    [field: SerializeField] private GameObject Left { get; set; }
    [field: SerializeField] private GameObject Right { get; set; }
    [field: SerializeField] private GameObject Down { get; set; }
}