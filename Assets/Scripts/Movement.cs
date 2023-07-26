using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private Vector2 pozycja;
    bool kierunek = false;
    public int Health;
    private int score = 0;
    public GameOverScript GameOverScreen;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            transform.position = new Vector3(-2f,0.5f,0);
            kierunek = true;
        }

        if (Input.GetKeyDown("right"))
        {
            transform.position = new Vector3(2f, 0.5f, 0);
            kierunek = false;
        }
        if (Health <=0  && !isDead)
        {
            isDead = true;
            GameOverScreen.gameOver(score);
            //SceneManager.LoadScene("SampleScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("left") && kierunek == true)
        {
            score += 1;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("left") && kierunek == false)
        {
            Debug.Log("GameOver");
            Health -= 1;
        }
        if (other.gameObject.CompareTag("right") && kierunek == false)
        {
            score += 1;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("right")&& kierunek == true)
        {
            Debug.Log("GameOver");
            Health -= 1;
        }
    }
    public void GameOver()
    {

    }
}
