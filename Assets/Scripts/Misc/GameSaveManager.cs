using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
public class GameSaveManager : MonoBehaviour, IGameEventListener<string>
{
    public StringGameEvent gameSaveSelectedEvent;
    public GameSave[] gameSaves;
    public GameObject[] gameSavePrefabs;
    public GameObject[] gameSaveStartingObjects;
    public StringVariable[] gameSaveNames;

    private void Start() 
    {
        gameSaveSelectedEvent.AddListener(this);
    }

    public void OnEventRaised(string gameSaveName)
    {
        for(int i=0; i<gameSaves.Length; i++ )
        {
            if(gameSaveName == gameSaveNames[i])
            {
                gameSaveStartingObjects[i].SetActive(false);
                GameObject item = Instantiate(gameSavePrefabs[i]);
                item.transform.position = gameSaveStartingObjects[i].GetComponent<Transform>().position;
                item.transform.Rotate(Vector3.up, 180);
            }
        }
    }
}
