using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        AudioSource source = FindObjectOfType<AudioSource>();
       /* foreach(AudioSource track in source)
        {
            Destroy(track);
        }*/
        
        Destroy(source);
    }
}
