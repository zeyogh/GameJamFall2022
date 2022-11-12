using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    [SerializeField]
    // TextMesh;
    TextMeshProUGUI text;

    public void displayText(DialogueSO dialogueSO)
    {
        text.text = dialogueSO.dialogueStrings[0];
    }
}
