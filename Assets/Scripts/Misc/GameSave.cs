using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "GameSave", menuName = "Project/GameSave", order = 0)]
public class GameSave : ScriptableObject 
{
    public bool gameSaveActivated = false;
    public int score = 0;
    public StringVariable[] completedLevels;

}