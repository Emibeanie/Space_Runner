using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Escape();
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Escape()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
