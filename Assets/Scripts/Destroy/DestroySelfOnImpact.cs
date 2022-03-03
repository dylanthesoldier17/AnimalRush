using System.Collections;
using UnityEngine;
public class DestroySelfOnImpact : MonoBehaviour
{
    public int delayToDestroyInSeconds = 1;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name} hit {gameObject.name}, Destroyed {gameObject.name}");
        StartCoroutine(DelayDestroy_CO(delayToDestroyInSeconds));
    }

    private IEnumerator DelayDestroy_CO(int delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        Destroy(this);
    }
}
