using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SugarButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Button pourButton;
    [SerializeField] GameObject sugarbag;
    [SerializeField] Sprite original;
    [SerializeField] Sprite pouring;
    [SerializeField] GameObject sugarFlood;

    private float pour = 0f;
    private float startTime = 0f;

    [SerializeField] GameObject sugar;

    private bool addedMax = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        startTime = Time.time;
        sugarbag.GetComponent<Image>().sprite = pouring;
        sugarFlood.SetActive(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pour += Time.time - startTime;
        sugarbag.GetComponent<Image>().sprite = original;
        sugarFlood.SetActive(false);
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
        else if (!addedMax)
        {
            pourButton.GetComponent<JamValues>().updateSugar(2);
            sugar.SetActive(true);
            sugar.transform.position += (new Vector3(0, 15));
            addedMax = true;
        }
        Debug.Log(pour);
        Debug.Log(pourButton.GetComponent<JamValues>().getSugar());
    }
}
