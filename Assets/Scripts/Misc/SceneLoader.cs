using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;
using UnityEngine.Events;

public class SceneLoader : MonoBehaviour, IGameEventListener
{
    public enum OnEvent { NONE, LOAD_SCENE, UNLOAD_SCENE, TOGGLE_LOAD_UNLOAD_SCENE }
    public GameEvent theEvent;
    public OnEvent onEventTrigger = OnEvent.NONE;

    public LoadSceneMode sceneLoadMode = LoadSceneMode.Additive;
    public StringVariable theSceneName;
    private string sceneName;
    public bool loadOnStart = false;

    public UnityEvent onLoadCompletion;
    
    private void Start() 
    {
        sceneName = theSceneName;

        if(loadOnStart)
        {     
            loadScene();
        }

        if(onEventTrigger != OnEvent.NONE)
        {
            theEvent.AddListener(this);
        }
    }

    public void loadScene()
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneName, sceneLoadMode);
        loadOperation.completed += notifyAllOnCompletionEvent;
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

    public void OnEventRaised()
    {
        switch(onEventTrigger)
        {
            case OnEvent.LOAD_SCENE: loadScene(); break;
            case OnEvent.UNLOAD_SCENE: unloadScene(); break;
            case OnEvent.TOGGLE_LOAD_UNLOAD_SCENE: 
                if(SceneManager.GetSceneByName(sceneName) == null)
                {
                    loadScene();
                } else {
                    unloadScene();
                }
            break;
        }
    }
    
    private void notifyAllOnCompletionEvent(AsyncOperation asyncOperation)
    {
        onLoadCompletion.Invoke();
    }
}