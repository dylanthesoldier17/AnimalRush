using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowProjectile : MonoBehaviour
{
    public GameObject[] projectiles;
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
            int index = Random.Range(0, projectiles.Length);
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
