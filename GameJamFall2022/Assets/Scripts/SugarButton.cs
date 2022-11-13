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

    [SerializeField] GameObject sugar;

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
        if (pour <= 2f)
        {
            pourButton.GetComponent<JamValues>().updateSugar(0);
        }
        else if (pour <= 4f)
        {
            pourButton.GetComponent<JamValues>().updateSugar(1);
            sugar.SetActive(true);
        }
        else
        {
            pourButton.GetComponent<JamValues>().updateSugar(2);
            sugar.SetActive(true);
            sugar.transform.position += (new Vector3(0, 15));
        }
        Debug.Log(pour);
        Debug.Log(pourButton.GetComponent<JamValues>().getSugar());
    }
}
