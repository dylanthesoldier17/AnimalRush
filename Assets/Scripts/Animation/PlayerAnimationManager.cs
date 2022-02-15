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
    private SpeedCalculator _speedCalculator;
    private static readonly int SpeedF = Animator.StringToHash("Speed_f");

    private void Start()
    {
        _speedCalculator = new SpeedCalculator(transform);
        StartCoroutine(AnimationControlCoroutine());
    }

    private IEnumerator AnimationControlCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(animationDelayInSeconds);
            
            float currentSpeed =  _speedCalculator.CalculateCurrentSpeed();

            animator.SetFloat(SpeedF, currentSpeed);
        }
    }

    private class SpeedCalculator
    {
        private readonly Transform _transform;

        private float _lastTimeStamp = Time.time;
        private float _deltaTime = 0;

        private Vector3 _lastPosition;
        private float _deltaPosition = 0;

        public SpeedCalculator(Transform transform)
        {
            _transform = transform;
        }

        public float CalculateCurrentSpeed()
        {
            _deltaTime = Time.time - _lastTimeStamp;
            _deltaPosition = (_transform.position - _lastPosition).magnitude;

            if(Mathf.Approximately(_deltaPosition, 0)){ _deltaPosition = 0; }

            _lastPosition = _transform.position;
            _lastTimeStamp = Time.time;

            return _deltaPosition / _deltaTime;
        }
    }
}
