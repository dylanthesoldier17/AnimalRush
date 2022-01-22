using UnityEngine;
using ScriptableObjectArchitecture;
using TMPro;
using UnityEngine.Serialization;

public class UpdateEnemyCounter : MonoBehaviour
{
    public IntGameEvent enemyCountChangeEvent;
    public TMP_Text displayText;
    
    private void Awake()
    {
        enemyCountChangeEvent.AddListener(updateCount);
    }

    public void updateCount(int count)
    {
        displayText.text = count.ToString();
    }
}
