using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBarSprite;
    
    public void UpdateHealthBar(float maxHealth, float currHealth)
    {
        healthBarSprite.fillAmount = currHealth / maxHealth;
    }
}
