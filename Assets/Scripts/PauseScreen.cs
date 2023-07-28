using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject PauseScr;
    private static bool isPaused = false;


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
    }
    public void Resume()
    {
        PauseScr.SetActive(false);
        isPaused = false;
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
