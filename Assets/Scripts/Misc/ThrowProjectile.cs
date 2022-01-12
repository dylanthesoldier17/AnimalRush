using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class ThrowProjectile : MonoBehaviour
{
    public GameObjectCollection projectiles;
    public Vector3 offset;
    public float reloadDelayinSeconds = 1;
    private bool loaded = true;
    
    // Update is called once per frame
    void Update()
    {
        fireProjectile();
    }

    private void fireProjectile()
    {
        if(Input.GetKeyDown(KeyCode.Space) && loaded)
        {
            int index = Random.Range(0, projectiles.Count);
            Instantiate(projectiles[index], (transform.position + offset), new Quaternion());
            loaded = false;
            StartCoroutine(reloadProjectile());
        }
    }

    private IEnumerator reloadProjectile()
    {
        yield return new WaitForSeconds(reloadDelayinSeconds);
        loaded = true;
    }
}
