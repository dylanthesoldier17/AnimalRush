using UnityEngine;
using ScriptableObjectArchitecture;

public class HandleProjectileImpact : MonoBehaviour
{
    public StringVariable projectileTag;
    public StringGameEvent enemyDestroyedEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(projectileTag))
        {
            enemyDestroyedEvent.Raise(this.name);
        }
    }
}
