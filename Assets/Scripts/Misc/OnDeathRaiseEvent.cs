using UnityEngine;
using ScriptableObjectArchitecture;

public class OnDeathRaiseEvent : MonoBehaviour
{
    public IntVariable playerHealth;
    public GameEvent onDeathEvent;
    public int deathOnHealthLessThanEqualTo = 0;

    private void Start() 
    {
        playerHealth.AddListener(action => 
        {   
            OnPlayerHealthChanged(action);
        }); 
    }
    
    public void OnPlayerHealthChanged(int playerHealth_Int)
    {
        #if UNITY_EDITOR
            Debug.Log($"Players Health Changed: {playerHealth_Int}");
        #endif

        if(playerHealth <= deathOnHealthLessThanEqualTo)
        {
            onDeathEvent.Raise();
        }
    }

}
