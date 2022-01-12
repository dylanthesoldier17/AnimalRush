using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;

public class SceneLoader : MonoBehaviour
{
    public LoadSceneMode sceneLoadMode = LoadSceneMode.Additive;
    public StringVariable theSceneName;
    private string sceneName;

    private void Start() 
    {
        sceneName = theSceneName;    
    }

    public void loadScene()
    {
        SceneManager.LoadSceneAsync(sceneName, sceneLoadMode);
    }

    public void unloadScene()
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }

    public void setScene(StringVariable sceneName)
    {
        this.sceneName = sceneName;
    }

    public void setScene(string sceneName)
    {
        this.sceneName = sceneName;
    }
}
