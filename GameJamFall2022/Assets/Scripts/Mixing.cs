using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mixing : MonoBehaviour
{

    private bool wasHeld = false;

    private float startPos = 0f;
    private float lastPos = 0f;
    private float mixDist = 0f;

    private char direction = 'n';

    [SerializeField] GameObject jamValues;
    [SerializeField] GameObject finishedButton;

    [SerializeField] Image image;
    [SerializeField] Sprite origSprite;
    [SerializeField] Sprite flippedSprite;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //held down
        {
            if (wasHeld == false)
            {
                startPos = Input.mousePosition.x;
                lastPos = Input.mousePosition.y;
                //Debug.Log("Starting pos: " + startPos);
            }
            wasHeld = true;

            if (direction == 'n' && Input.mousePosition.x > startPos)
            {
                direction = 'r';
                image.sprite = flippedSprite;
                //Debug.Log("going right");
            }
            else if (direction == 'n' && Input.mousePosition.x < startPos)
            {
                direction = 'l';
                image.sprite = origSprite;
                //Debug.Log("going left");
            }
            //changing to left direction
            if (direction == 'r' && Input.mousePosition.x < lastPos)
            {
                direction = 'l';
                mixDist += Mathf.Abs(startPos - Input.mousePosition.x);
                //Debug.Log("right -> left MixDist: " + mixDist + " Current: " + startPos + " MS: " + Input.mousePosition.x);
                startPos = Input.mousePosition.x;
                image.sprite = origSprite;
            }
            //changing to right direction
            else if (direction == 'l' && Input.mousePosition.x > lastPos)
            {
                direction = 'r';
                mixDist += Mathf.Abs(startPos - Input.mousePosition.x);
                //Debug.Log("left -> right MixDist: " + mixDist + " Current: " + startPos + " MS: " + Input.mousePosition.x);
                startPos = Input.mousePosition.x;
                image.sprite = flippedSprite;
            }
            lastPos = Input.mousePosition.x;
        }
        if (wasHeld && !Input.GetMouseButton(0)) //not held down
        {
            wasHeld = false;
            mixDist += Mathf.Abs(startPos - Input.mousePosition.x);
            startPos = Input.mousePosition.x;
            direction = 'n';
            //Debug.Log("Stopped holding val: " + mixDist + " startPos: " + Input.mousePosition.x);
            if (mixDist >= 10000f)
            {
                finishedButton.SetActive(true);
            }

        }
    }
}
