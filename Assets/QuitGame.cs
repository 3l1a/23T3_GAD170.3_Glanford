using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void ApplicationQuit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void LodeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
}
