using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public TMP_Text pointsText;
    public TMP_Text ScoreText;
    public TMP_Text hsText;
    // Start is called before the first frame update

    public void GameOver(int score)
    {
        gameOverUI.SetActive(true);
        pointsText.text = score.ToString() + " Points";
        Time.timeScale = 0f;
        PauseScreen.isPaused = true;
        hsText.text ="Highscore: " + PlayerPrefs.GetInt("HighScore",0);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        PauseScreen.isPaused = false;
    }
    public void Score(int score)
    {
        ScoreText.gameObject.SetActive(true);
        ScoreText.text = "Points : " + score.ToString();
    }
}
