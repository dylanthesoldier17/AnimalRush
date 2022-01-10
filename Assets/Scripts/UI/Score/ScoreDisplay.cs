using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.Events;

public class ScoreDisplay : MonoBehaviour
{
    public FloatVariable playerScore;
    public TMPro.TMP_Text scoreTextMeshText;

    public void updateScore()
    {
        scoreTextMeshText.text = playerScore.Value.ToString();
    }
}
