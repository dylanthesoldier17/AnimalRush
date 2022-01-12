using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseGameEventOnLifecycle : MonoBehaviour
{
    public bool enableEvents = true;
    public enum lifecycleMethod {NONE, START, AWAKE, ON_DESTROY, ON_ENABLE, ON_DISABLE}
    public lifecycleMethod selectLiftcycleMethod = lifecycleMethod.NONE;
    public GameEvent gameEvent;

    // Start is called before the first frame update
    private void Start()
    {
        if(selectLiftcycleMethod == lifecycleMethod.START && enableEvents == true)
        {
            gameEvent.Raise();
        }
    }

    private void Awake() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.AWAKE && enableEvents == true)
        {
            gameEvent.Raise();
        }
    }

    private void OnDestroy() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_DESTROY && enableEvents == true)
        {
            gameEvent.Raise();
        }
    }

    private void OnDisable() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_DISABLE && enableEvents == true)
        {
            gameEvent.Raise();
        }
    }

    private void OnEnable() 
    {
        if(selectLiftcycleMethod == lifecycleMethod.ON_ENABLE && enableEvents == true)
        {
            gameEvent.Raise();
        }
    }
}