using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DialogueSO", menuName = "Dialogue")]
public class DialogueSO : ScriptableObject
{
    [SerializeField]
    public List<string> dialogueStrings;


}
