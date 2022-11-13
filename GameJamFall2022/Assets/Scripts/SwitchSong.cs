using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSong : MonoBehaviour
{
    [SerializeField] AudioClip nextSong;

    [SerializeField] AudioSource currAudioSource;

    public void changeSong()
    {
    //    AudioSource source = FindObjectOfType<AudioSource>();
        currAudioSource.clip = nextSong;
    }


    public void endSong()
    {
        AudioSource source = FindObjectOfType<AudioSource>();
        Destroy(source);
    }


}
