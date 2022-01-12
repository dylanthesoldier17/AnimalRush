using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    public StringVariable sceneName;
    public LoadSceneMode sceneLoadMode = LoadSceneMode.Additive;
    public LoadOnState loadOnState = LoadOnState.NONE;

    private void Awake()
    {
        if(loadOnState == LoadOnState.AWAKE)
        {
            loadScene();
        }
    }

    private void OnEnable() 
    {
        if(loadOnState == LoadOnState.ENABLE)
        {
            loadScene();
        }    
    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName, sceneLoadMode);
    }

    public void unloadScene()
    {
        SceneManager.UnloadScene(sceneName);
    }

    public enum LoadOnState { NONE, AWAKE, ENABLE }
}
