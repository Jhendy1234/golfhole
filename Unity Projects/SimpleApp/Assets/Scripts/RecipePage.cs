using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypePage : MonoBehaviour
{
    public void Recipe1()
    {
        SceneManager.LoadScene("Recipe Page");
    }
    /*
        public void Recipe2()
        {
            SceneManager.LoadScene("Type Page");
        }

        public void Recipe3()
        {
            SceneManager.LoadScene("Type Page");
        }

        public void Recipe4()
        {
            SceneManager.LoadScene("Type Page");
        }

        public void Recipe5()
        {
            SceneManager.LoadScene("Type Page");
        }
    */
    public void Back()
    {
        SceneManager.LoadScene("Type Page");
    }



    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

