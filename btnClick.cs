using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnClick : MonoBehaviour
{
    public AudioSource btnAudioSource;
    public AudioClip soundClick;


    public void ClickSound()
    {
        btnAudioSource.PlayOneShot(soundClick);
    }
}
