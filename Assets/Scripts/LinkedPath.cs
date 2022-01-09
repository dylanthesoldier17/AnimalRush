using UnityEngine;

//[CreateAssetMenu(fileName = "LinkedPathItem", menuName = "Paths/LinkedPath", order = 0)]
public class LinkedPath : MonoBehaviour 
{
    [field: SerializeField] public LinkedPath Up { get; set; }
    [field: SerializeField] public LinkedPath Left { get; set; }
    [field: SerializeField] public LinkedPath Right { get; set; }
    [field: SerializeField] public LinkedPath Down { get; set; }
}