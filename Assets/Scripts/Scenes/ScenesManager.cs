using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("PongGame");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MainMenuReset()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
