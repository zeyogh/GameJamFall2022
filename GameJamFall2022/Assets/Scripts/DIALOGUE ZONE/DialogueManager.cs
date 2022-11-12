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


    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //  Debug.Log("Starting conversation with " + dialogue.NPCName);

        dialoguePanel.SetActive(true);
        continueButton.SetActive(true);
        sentences.Clear();
        nameText.text = dialogue.NPCName;

        foreach (string sentence in dialogue.sentences)
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
   //     Debug.Log("End of conversation");
        dialoguePanel.SetActive(false);
        continueButton.SetActive(false);

    }
}
