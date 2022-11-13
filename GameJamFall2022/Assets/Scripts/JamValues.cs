using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class JamValues : MonoBehaviour
{
    /*
     * [Fruit, Cut, Sugar, Mix]
     */
    private static int[] jamValues = new int[3] { -1, 0, 0 };

    private static string speaker = "raccoon";



    //void Awake()
    //{
    //    jamValues = new int[3] { -1, -1, -1};
    //}

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
        Debug.Log(jamValues[1]);
    }

    public void updateSpeaker()
    {
        string scene = SceneManager.GetActiveScene().name;

        if (scene.Equals("RaccoonCounter"))
        {
            speaker = "raccoon";
        }
        else if (scene.Equals("CrowCounter"))
        {
            speaker = "crow";
        }
        else if (scene.Equals("FrogCounter"))
        {
            speaker = "frog";
        }
        else if (scene.Equals("FrogEndCounter"))
        {
            speaker = "coyote";
        }
        else if (scene.Equals("CoyoteCounter")) {
            speaker = "coyote";
        }
    }


    public bool equals(int[] customerPreference)
    {

        if (speaker.Equals("raccoon"))
        {
            Debug.Log("raccoon maaaaan");
            return raccoonTest();
        }

        if (jamValues[0] != customerPreference[0] || jamValues[2] != customerPreference[2])
        {
            Debug.Log("1 or 3 incorrect!");
            return false;
        }

        if (customerPreference[1] == 0 && (jamValues[1] == 0 || jamValues[1] == 1))
        {
            return true;
        }
        else
        {
            Debug.Log("first didn't work");
        }

        if (customerPreference[1] == 2 && (jamValues[1] == 2 || jamValues[1] == 3))
        {
            return true;
        }
        else
        {
            Debug.Log("second didn't work");
        }

        if (customerPreference[1] == 4 && jamValues[1] >= 4)
        {
            return true;
        }
        else
        {
            Debug.Log("third didn't work");
        }

        Debug.Log("fell here!");
        return false;
    }

    public void refresh()
    {
        jamValues[1] = 0;
        jamValues[2] = 0;
    }    

    public string getSpeaker()
    {
        return speaker;
    }
    
    private bool raccoonTest()
    {
        if (jamValues[0] == 0)
        {
            return true;
        }
        return false;
    }

    public void printJam()
    {
        string jam = jamValues[0] + " " + jamValues[1] + " " + jamValues[2];

        Debug.Log(jam);
    }

}
