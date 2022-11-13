using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public CharacterSO character;
    public DialogueManager manager;


    public void TriggerDialogue()
    {
        manager = FindObjectOfType<DialogueManager>();
        manager.StartDialogue(dialogue);
    }


    public void TriggerJamResponse()
    {

        // bool jamMatches = FindObjectOfType<JamValues>().equals(character.jamPreference);
        bool jamMatches = true;
        
        if (jamMatches)
        {
            dialogue = character.positiveResponse;
        } else
        {
            dialogue = character.negativeResponse;
        }

        if (!jamMatches && character.name.Equals("Coyote"))
        {
            Debug.Log("You died");
            SceneManager.LoadScene("CoyoteGameOver");
        } else
        {
            TriggerDialogue();
        }

        
    }
}
