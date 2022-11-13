using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private DialogueManager manager;

    public void TriggerDialogue()
    {
        manager = FindObjectOfType<DialogueManager>();
        manager.StartDialogue(dialogue);
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
