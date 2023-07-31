using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float speed =4f;
    // Start is called before the first frame update
    public HealthBar healthBar;
    public float maxHealth = 1f;
    public float currentHealth = 1f;

    void Start()
    {
        Time.timeScale = speed;
        healthBar.UpdateHealthBar(maxHealth, currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 0)
        {
            currentHealth -= 0.05f*Time.deltaTime;
            healthBar.UpdateHealthBar(maxHealth,currentHealth);
        }
    }
}
