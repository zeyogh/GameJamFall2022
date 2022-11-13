using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialCheck : MonoBehaviour
{
    [SerializeField] GameObject text;


    private void Start()
    {
        string speaker = FindObjectOfType<JamValues>().getSpeaker();

        if (speaker.Equals("raccoon"))
        {
            text.SetActive(true);
        }
    }
}
