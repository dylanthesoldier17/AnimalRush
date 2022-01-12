using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class SceneSelector : MonoBehaviour
{
    public StringGameEvent areaChangeEvent;
    public SceneLoader sceneLoader; 

    private void Start() 
    {
        areaChangeEvent.AddListener(action => 
        {
            updateSceneloader(action);
        });
    }

    public void updateSceneloader(string sceneName)
    {
        sceneLoader.setScene(sceneName);
    }
}
