using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ChangeScene(int targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }

    public void ExitGame()
    {
        Debug.Log("Closing game...");
        Application.Quit();
    }
}
