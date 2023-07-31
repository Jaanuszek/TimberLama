using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject PauseScr;
    public GameOverScript GameOverManager;
    public static bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        PauseScr.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
       // GameOverManager.ScoreText.gameObject.SetActive(false);
    }
    public void Resume()
    {
        PauseScr.SetActive(false);
        isPaused = false;
        Time.timeScale = 4f;
        //GameOverManager.ScoreText.gameObject.SetActive(true); //nie dziala :/
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
        isPaused = false;
    }
}
