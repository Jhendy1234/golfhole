using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayBike()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayPutt()
    {
        SceneManager.LoadScene("Game2");
    }
    public void PlayGolfGreen()
    {
        SceneManager.LoadScene("Game4");
    }


    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

