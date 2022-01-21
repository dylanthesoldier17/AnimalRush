using UnityEngine;
public class DestroySelfOnImpact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} hit {gameObject.name}, Destroyed {gameObject.name}");
        Destroy(this.gameObject);
    }
}
