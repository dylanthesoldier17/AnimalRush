using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

/* Used "How to make a Health Bar in Unity!" by Brackeys at [https://www.youtube.com/watch?v=BLfNP4Sc_iA] */
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public IntVariable playerHealth, playerMaxHealth;

    private void Start()
    {
        setMaxHealth(playerMaxHealth);
    }

    public void setMaxHealth(IntVariable health)
    {
        slider.maxValue = health.Value;
        slider.value = health.Value;
    }

    public void updateHealth()
    {
        slider.value = playerHealth.Value;
    }
}
