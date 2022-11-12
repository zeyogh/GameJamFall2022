using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamValues : MonoBehaviour
{
    /*
     * [Fruit, Cut, Sugar, Mix]
     */
    private int[] jamValues;

    void Awake()
    {
        jamValues = new int[4];
    }

    public void updateFruit(int fruit)
    {
        int[0] = fruit;
    }

}
