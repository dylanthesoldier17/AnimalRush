using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public StringVariable[] excludeTags;
    private void OnTriggerEnter(Collider other)
    {
        foreach (StringVariable stringVariable in excludeTags)
        {
            if (other.tag.Equals(stringVariable.Value))
                return;
        }
        audioSource.PlayOneShot(audioClip);
    }
}
