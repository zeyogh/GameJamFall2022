using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSong : MonoBehaviour
{
    [SerializeField] AudioClip nextSong;

    public void changeSong()
    {
        AudioSource source = FindObjectOfType<AudioSource>();
        source.clip = nextSong;
    }

}
