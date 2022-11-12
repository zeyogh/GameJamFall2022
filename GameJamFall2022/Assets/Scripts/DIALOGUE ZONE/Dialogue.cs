using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue")]
[System.Serializable]
public class Dialogue : ScriptableObject
{
     
    public string NPCName;
    [TextArea(3, 10)]
    public string[] sentences;
    public Dialogue nextDialogue;


}
