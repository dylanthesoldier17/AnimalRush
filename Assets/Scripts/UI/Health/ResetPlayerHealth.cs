using UnityEngine;
using ScriptableObjectArchitecture;

public class ResetPlayerHealth : MonoBehaviour
{
    public IntVariable playerHealth, playerMaxHealth;
    public GameEvent healthChangeEvent;

    void Start()
    {
        playerHealth.Value = playerMaxHealth.Value;
        healthChangeEvent.Raise(); 
    }
}
