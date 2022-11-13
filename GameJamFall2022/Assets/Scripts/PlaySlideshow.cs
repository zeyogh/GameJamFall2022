using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySlideshow : MonoBehaviour
{
    [SerializeField] Image currentSlide;
    [SerializeField] string startOrEnd;

    [SerializeField] Sprite slide0;
    [SerializeField] Sprite slide1;
    [SerializeField] Sprite slide2;
    [SerializeField] Sprite slide3;
    [SerializeField] Sprite slide4;
    [SerializeField] Sprite slide5;
    [SerializeField] Sprite slide6;

    private Sprite[] sprites;
    int index = 1;

    private void Start()
    {
        sprites = new Sprite[7];
        sprites[0] = slide0;
        sprites[1] = slide1;
        sprites[2] = slide2;
        sprites[3] = slide3;
        sprites[4] = slide4;
        sprites[5] = slide5;
        sprites[6] = slide6;

    }



    public void flipToNext()
    {
        currentSlide.sprite = sprites[index];
        index++;
    }

}
