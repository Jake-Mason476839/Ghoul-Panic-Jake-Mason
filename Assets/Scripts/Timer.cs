using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeRemaining = 30;
    public bool timerIsRunning = false;
    public static int ghostCount = 0;

    private void Start()
    {
        timerIsRunning = true;
    }

    public void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

                if(ghostCount >= 20)
                {
                    SceneManager.LoadScene(4);
                }

                else
                {
                    SceneManager.LoadScene(5);
                }
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0}", seconds);
    }
}
