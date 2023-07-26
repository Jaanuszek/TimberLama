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
    // Start is called before the first frame update

    public void gameOver(int score)
    {
        gameOverUI.SetActive(true);
        pointsText.text = score.ToString() + " Points";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
