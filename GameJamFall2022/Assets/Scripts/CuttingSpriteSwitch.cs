using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuttingSpriteSwitch : MonoBehaviour
{
    [SerializeField] GameObject jamValues;
    [SerializeField] Image image;

    [SerializeField] Sprite appleWhole;
    [SerializeField] Sprite appleCut;
    [SerializeField] Sprite appleCrushed;

    [SerializeField] Sprite strawberryWhole;
    [SerializeField] Sprite strawberryCut;
    [SerializeField] Sprite strawberryCrushed;

    [SerializeField] Sprite blueberryWhole;
    [SerializeField] Sprite blueberryCut;
    [SerializeField] Sprite blueberryCrushed;

    [SerializeField] Sprite meatWhole;
    [SerializeField] Sprite meatCut;
    [SerializeField] Sprite meatCrushed;

    private void Awake()
    {
        int type = jamValues.GetComponent<JamValues>().getType();
        if (type == 0)
        {
            image.sprite = appleWhole;
        }
        else if (type == 1)
        {
            image.sprite = strawberryWhole;
        }
        else if (type == 2)
        {
            image.sprite = blueberryWhole;
        }
        else
        {
            image.sprite = meatWhole;
        }

    }

}
