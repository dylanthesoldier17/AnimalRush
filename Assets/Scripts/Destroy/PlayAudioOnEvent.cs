using UnityEngine;
using ScriptableObjectArchitecture;

public class PlayAudioOnEvent : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClipGameEvent theEvent;

    private void Awake()
    {
        theEvent.AddListener(playNow);
    }
    public void playNow(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
