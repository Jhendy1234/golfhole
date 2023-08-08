using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageMenu : MonoBehaviour
{
    public void PreWorkout()
    {
        SceneManager.LoadScene("Type Page");
    }

    public void Snacks()
    {
        SceneManager.LoadScene("Type Page");
    }

    public void PostWorkout()
    {
        SceneManager.LoadScene("Type Page");
    }

    public void Desserts()
    {
        SceneManager.LoadScene("Type Page");
    }

    public void TipsAndTricks()
    {
        SceneManager.LoadScene("Type Page");
    }



    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

