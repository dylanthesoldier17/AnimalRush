using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.Events;

public class ScoreDisplay : MonoBehaviour
{
    public FloatVariable playerScore;
    //public UnityEvent scoreUpdatedEvent;
    public TMPro.TMP_Text scoreTextMeshText;

    private void Start()
    {
        //TODO: Setup ScritableObject Events to make this more efficient from polling in the update loop to event based.

        //playerScore.AddListener(score =>
        //{
        //    scoreTextMeshText.text = playerScore.Value.ToString();
         //   Debug.Log($"Score Updated {playerScore.Value}");
        //});
    }

    private void Update()
    {
        updateScore();
    }

    public void updateScore()
    {
        scoreTextMeshText.text = playerScore.Value.ToString();
    }
}
