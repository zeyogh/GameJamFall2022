using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;
    public Image characterSprite;
    public Button continueButton;
    public Button dialogueButton;
    public Button loadNextScene;

    public Dialogue[] startConversation;
    public CharacterSO[] characters;
    public Queue<Dialogue> startConvos;


    private Queue<string> sentences;
    private Dialogue currDialogue;


    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void hideButton(Button button)
    {
        button.gameObject.SetActive(false);
    }

    public void showButton(Button button)
    {
        button.gameObject.SetActive(true);
    }


    public void StartDialogue(Dialogue dialogue)
    {
        //  Debug.Log("Starting conversation with " + dialogue.NPCName);

        currDialogue = dialogue;
        if (dialogue.character.NPCSprite != null)
        {
            characterSprite.sprite = dialogue.character.NPCSprite;
            characterSprite.gameObject.SetActive(true);
        }
        else if (dialogue.character.NPCSprite == null && !dialogue.character.name.Equals("You"))
        {
            characterSprite.gameObject.SetActive(false);
        }
        
        dialoguePanel.SetActive(true);
        continueButton.gameObject.SetActive(true);
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
         //   characterSprite.gameObject.SetActive(false);
            continueButton.gameObject.SetActive(false);
            loadNextScene.gameObject.SetActive(true);
        }
        else
        {
            StartDialogue(currDialogue.nextDialogue);
        }
       
    }
}
