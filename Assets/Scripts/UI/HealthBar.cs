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
    public IntVariable playerHealth; // Setup ScriptableObject events for on change update UI.
    public int maxValue = 100;

    private void Start()
    {
        setMaxHealth(maxValue);
    }

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealth(int health)
    {
        slider.value = health;
    }
}
