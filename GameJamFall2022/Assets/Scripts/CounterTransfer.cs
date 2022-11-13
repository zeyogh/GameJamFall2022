using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CounterTransfer : MonoBehaviour
{
    private static string counter = "coyote";

    public void activate()
    {
        string speaker = FindObjectOfType<JamValues>().getSpeaker();

        if (speaker.Equals("raccoon"))
        {
            counter = "crow";
        }

        else if (speaker.Equals("crow"))
        {
            counter = "frog";
        }

        else if (speaker.Equals("frog"))
        {
            counter = "frogend";
        }

        else
        {
            counter = "end";
        }

        /*loadScreen(counter);

        if (counter.Equals("crow"))
        {
            counter = "frog";
        }

        else if (counter.Equals("frog"))
        {
            counter = "coyote";
        }

        else if (counter.Equals("coyote"))
        {
            counter = "end";
        }*/

        Debug.Log(counter);
        loadScreen(counter);
    }

    public void loadScreen(string animal)
    {
        if (animal.Equals("raccoon"))
        {
            SceneManager.LoadScene("RaccoonCounter");
        }

        if (animal.Equals("crow"))
        {
            SceneManager.LoadScene("CrowCounter");
        }

        if (animal.Equals("frog"))
        {
            SceneManager.LoadScene("FrogCounter");
        }

        if (animal.Equals("coyote"))
        {
            SceneManager.LoadScene("CoyoteCounter");
        }

        if (animal.Equals("end"))
        {
            SceneManager.LoadScene("End");
        }

        if (animal.Equals("frogend"))
        {
            SceneManager.LoadScene("FrogEndCounter");
        }

    }
}
