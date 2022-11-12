using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerJamResponse(CharacterSO character)
    {
        bool jamMatches = FindObjectOfType<JamValues>().equals(character.jamPreference);
        
        if (jamMatches)
        {
            dialogue = character.positiveResponse;
        } else
        {
            dialogue = character.negativeResponse;
        }

        TriggerDialogue();

        if (!jamMatches && character.name == "Coyote")
        {
            SceneManager.LoadScene("CoyoteGameOver");
        }
    }
}
