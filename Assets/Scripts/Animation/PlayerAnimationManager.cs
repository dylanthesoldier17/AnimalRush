using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* https://stackoverflow.com/questions/55042997/how-to-calculate-a-gameobjects-speed-in-unity */
public class PlayerAnimationManager : MonoBehaviour
{
    /*
    * This class start a coroutine that calculates the current speed and updates the animator.
    */
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public float animationDelayInSeconds = 1;

    private void Start()
    {
        StartCoroutine("handleSpeed");
    }

    private IEnumerator handleSpeed()
    {
        float lastTimeStamp = Time.time;
        float deltaTime = 0;

        Vector3 lastPosition = transform.position;
        float deltaPosition = 0;

        while (enabled)
        {
            yield return new WaitForSeconds(animationDelayInSeconds);
            
            deltaTime = Time.time - lastTimeStamp;
            deltaPosition = (transform.position - lastPosition).magnitude;

            if(Mathf.Approximately(deltaPosition, 0)){ deltaPosition = 0; }

            lastPosition = transform.position;
            lastTimeStamp = Time.time;

            float currentSpeed =  deltaPosition / deltaTime;

            animator.SetFloat("Speed_f", currentSpeed);

            //Debug.Log(currentSpeed);
        }
    }
}
