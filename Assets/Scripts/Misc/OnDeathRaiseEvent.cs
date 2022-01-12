using UnityEngine;
using ScriptableObjectArchitecture;

public class OnDeathRaiseEvent : MonoBehaviour
{
    public IntVariable playerHealth;
    public GameEvent onDeathEvent;
    public int deathOnHealthLessThanEqualTo = 0;
    public Animator playerAnimator;
    public bool enableOnDeathAnimation;
    public StringVariable onDeathAnimationString;

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
            if(enableOnDeathAnimation)
            {
                playerAnimator.SetBool(onDeathAnimationString, true);
            }
            onDeathEvent.Raise();
        }
    }

}
