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

    public void checkCut()
    {
        int cut = jamValues.GetComponent<JamValues>().getCut();

        if (cut == 2 || cut == 3)
        {
            cutFood();
        }

        else if (cut >= 4)
        {
            crushedFood();
        }
    }

    private void cutFood()
    {
        if (image.sprite == appleWhole)
        {
            image.sprite = appleCut;
        }
        else if (image.sprite == strawberryWhole)
        {
            image.sprite = strawberryCut;
        }
        else if (image.sprite == blueberryWhole)
        {
            image.sprite = blueberryCut;
        }
        else if (image.sprite == meatWhole)
        {
            image.sprite = meatCut;
        }
    }

    private void crushedFood()
    {
        if (image.sprite == appleCut)
        {
            image.sprite = appleCrushed;
        }
        else if (image.sprite == strawberryCut)
        {
            image.sprite = strawberryCrushed;
        }
        else if (image.sprite == blueberryCut)
        {
            image.sprite = blueberryCrushed;
        }
        else if (image.sprite == meatCut)
        {
            image.sprite = meatCrushed;
        }
    }

}
