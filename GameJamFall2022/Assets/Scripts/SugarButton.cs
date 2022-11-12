using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SugarButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Button pourButton;

    private float pour = 0f;
    private float startTime = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        startTime = Time.time;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pour += Time.time - startTime;
    }

    public void addPour()
    {
        if (pour <= 3f)
        {
            pourButton.GetComponent<JamValues>().updateSugar(0);
        }
        else if (pour <= 6f)
        {
            pourButton.GetComponent<JamValues>().updateSugar(1);
        }
        else
        {
            pourButton.GetComponent<JamValues>().updateSugar(2);
        }
        Debug.Log(pour);
        Debug.Log(pourButton.GetComponent<JamValues>().getSugar());
    }
}
