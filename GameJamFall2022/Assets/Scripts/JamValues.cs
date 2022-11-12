using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JamValues : MonoBehaviour
{
    /*
     * [Fruit, Cut, Sugar, Mix]
     */
    private static int[] jamValues;


    void Awake()
    {
        jamValues = new int[3] { -1, -1, -1};
    }

    /*
     * 0 = apple, 1 = strawberry, 2 = blueberry, 3 = mystery meat
     */
    public void updateFruit(int fruit)
    {
        jamValues[0] = fruit;
        Debug.Log(jamValues.ToString() + jamValues[0]);
    }

    /*
     * 0 = whole, 2 = cut, 4 = crushed
     */
    public void updateCut(int cut)
    {
        jamValues[1] = cut;
    }

    /*
     * 0 = low, 1 = mid, 2 = high
     */
    public void updateSugar(int sugar)
    {
        jamValues[2] = sugar;
    }

    public int getSugar()
    {
        return jamValues[2];
    }

    public void cut()
    {
        jamValues[1]++;
        Debug.Log(jamValues.ToString() + jamValues[1]);
    }

}
