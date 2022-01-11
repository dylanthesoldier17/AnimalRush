using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;

public class LevelManager : MonoBehaviour
{
    public StringGameEvent selectedLevelEvent;
    public IntGameEvent launchLevelEvent;
    private string selectedLevel;
    public KeyCode listenForKey;

    private void Start()
    {
        selectedLevelEvent.AddListener(action =>
        {
            setLevel(action.ToString());
        });

        launchLevelEvent.AddListener(action =>
        {
            if(action == (int)listenForKey){
                loadLevel();
            }
        });
    }



    public void setLevel(StringGameEvent scene_name)
    {
        setLevel(scene_name);
    }

    public void setLevel(string scene_name)
    {
        selectedLevel = scene_name;
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(selectedLevel);
    }
}
