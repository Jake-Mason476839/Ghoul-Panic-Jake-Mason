using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Japanese()
    {
        SceneManager.LoadScene(1);
    }

    public void English()
    {
        SceneManager.LoadScene(0);
    }
}
