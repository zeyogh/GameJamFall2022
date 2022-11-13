using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character")]
[System.Serializable]
public class CharacterSO : ScriptableObject
{
    public int[] jamPreference = new int[3];
    public string NPCName;
    public Sprite NPCSprite;
    public Dialogue positiveResponse;
    public Dialogue negativeResponse;
    public bool canMurderYou;
    
    public Dialogue GetJamResponseDialogue(bool jamMatches)
    {
        if (jamMatches)
        {
            return positiveResponse;
        } else
        {
            return negativeResponse;
        }
    }
}
