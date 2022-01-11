using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.SceneManagement;

public class LoadUIOnEvent : MonoBehaviour
{
    public StringVariable sceneName;

    private void loadScene() 
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}
