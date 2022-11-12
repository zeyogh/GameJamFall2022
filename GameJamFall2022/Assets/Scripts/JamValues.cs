using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void updateSugar(int sugar)
    {
        jamValues[2] = sugar;
    }

    public void cut()
    {
        jamValues[1]++;
    }

}
