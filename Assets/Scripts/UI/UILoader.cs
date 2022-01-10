using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.SceneManagement;

public class UILoader : MonoBehaviour
{
    public StringVariable sceneName;

    private void Awake() 
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}
