using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;
    public GameObject continueButton;
    private Queue<string> sentences;
    private Dialogue currDialogue;


    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //  Debug.Log("Starting conversation with " + dialogue.NPCName);
        currDialogue = dialogue;
        dialoguePanel.SetActive(true);
        continueButton.SetActive(true);
        sentences.Clear();
        nameText.text = currDialogue.character.NPCName;

        foreach (string sentence in currDialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
      //  Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        if (currDialogue.nextDialogue == null)
        {
            dialoguePanel.SetActive(false);
            continueButton.SetActive(false);
        }
        else
        {
            StartDialogue(currDialogue.nextDialogue);
        }
       
    }
}
