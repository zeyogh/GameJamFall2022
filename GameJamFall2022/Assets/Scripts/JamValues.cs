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

    public bool equals(int[] customerPreference)
    {
        for (int i = 0; i < jamValues.Length; i++)
        {
            if (jamValues[i] != customerPreference[i])
            {
                return false;
            }
        }
        return true;
    }

    public void printJam()
    {
        string jam = jamValues[0] + "";
        if (jamValues[0] == 0) { jam += "apple"; }
        else if (jamValues[0] == 1) { jam += "strawberry"; }
        else if (jamValues[0] == 2) { jam += "blueberry"; }
        else { jam += "MM"; }

        if (jamValues[1] == 0 || jamValues[1] == 1) { jam += "whole"; }
        else if (jamValues[1] == 2 || jamValues[1] == 3) { jam += "cut"; }
        else if (jamValues[1] >= 4) { jam += "crushed"; }

        if (jamValues[2] == 0) { jam += "low"; }
        else if (jamValues[1] == 1) { jam += "mid"; }
        else if (jamValues[1] >= 2) { jam += "high"; }

        Debug.Log(jam);
    }

}
