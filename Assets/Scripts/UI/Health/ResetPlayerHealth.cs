using UnityEngine;
using ScriptableObjectArchitecture;

public class ResetPlayerHealth : MonoBehaviour
{
    public IntVariable playerHealth, playerMaxHealth;
    public GameEvent healthChangeEvent;

    void Start()
    {
        setHealthToMax();
    }

    public void setHealthToMax()
    {
        playerHealth.Value = playerMaxHealth.Value;
        healthChangeEvent.Raise(); 
    }
}
