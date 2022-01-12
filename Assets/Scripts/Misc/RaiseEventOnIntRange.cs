using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class RaiseEventOnIntRange : MonoBehaviour
{
    public enum Operations { LESS_THAN, LESS_THAN_OR_EQUAL_TO, EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL_TO }
    public IntVariable theInt;
    public Operations selectOperation;
    public int checkAgainst;
    public GameEvent[] raiseEvents;

    private void Start() 
    {
        theInt.AddListener(action => {
            checkInt();
        });    
    }

    public void checkInt()
    {
        switch(selectOperation)
        {
            case Operations.EQUAL_TO:
                if(theInt == checkAgainst){ raiseAllEvents(); }
                break;
            
            case Operations.GREATER_THAN: 
                if(theInt > checkAgainst){ raiseAllEvents(); }
                break;
            
            case Operations.GREATER_THAN_OR_EQUAL_TO: 
                if(theInt >= checkAgainst){ raiseAllEvents(); }
                break;
            
            case Operations.LESS_THAN: 
                if(theInt < checkAgainst){ raiseAllEvents(); }
                break;
            
            case Operations.LESS_THAN_OR_EQUAL_TO: 
                if(theInt <= checkAgainst){ raiseAllEvents(); }
                break;
        }
    }

    private void raiseAllEvents()
    {
        foreach(GameEvent gameEvent in raiseEvents)
        {
            gameEvent.Raise();
        }
    }
}
