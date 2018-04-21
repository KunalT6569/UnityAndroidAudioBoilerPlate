using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultAudioSystemClick : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip AudioClip;

    public void PlayDefaultAudioSystemClickSound()
    {
        AudioSource.PlayOneShot(AudioClip);
    }
}
