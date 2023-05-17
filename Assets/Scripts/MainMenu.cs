using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void PlayGame()
    {
        SceneManager.LoadScene("Start");
    }

    void ExitGame()
    {
        Application.Quit();
        print("exit");
    }
}
