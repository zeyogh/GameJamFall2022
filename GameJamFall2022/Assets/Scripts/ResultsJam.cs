using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsJam : MonoBehaviour
{

    [SerializeField] GameObject jamValues;

    [SerializeField] GameObject image;

    [SerializeField] Sprite appleJam;
    [SerializeField] Sprite strawberryJam;
    [SerializeField] Sprite blueberryJam;
    [SerializeField] Sprite meatJam;

    // Start is called before the first frame update
    void Start()
    {
        int food = jamValues.GetComponent<JamValues>().getType();

        if (food == 0)
        {
            image.GetComponent<SpriteRenderer>().sprite = appleJam;
        }
        else if (food == 1)
        {
            image.GetComponent<SpriteRenderer>().sprite = strawberryJam;
        }
        else if (food == 2)
        {
            image.GetComponent<SpriteRenderer>().sprite = blueberryJam;
        }
        else if (food == 3)
        {
            image.GetComponent<SpriteRenderer>().sprite = meatJam;
        }
    }
}
