using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void changeScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
