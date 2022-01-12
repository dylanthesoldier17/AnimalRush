using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEditor;

[ExecuteInEditMode]
public class ResetPlayerHealth : MonoBehaviour
{
    public IntVariable playerHealth, playerMaxHealth;
    public GameEvent healthChangeEvent;

    void Awake()
    {
        setHealthToMax();
    }

    public void setHealthToMax()
    {
        playerHealth.Value = playerMaxHealth.Value;
        healthChangeEvent.Raise(); 
    }

    private void OnDestroy() 
    {
        setHealthToMax(); 
    }
}
