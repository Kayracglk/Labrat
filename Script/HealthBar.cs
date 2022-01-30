using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public int currentHealth=1000, maxHealth = 1000;
    [SerializeField] GameObject player;
    [SerializeField] TextMeshProUGUI healthText;
    void Update()
    {
         BarSystem();
    }
    public void BarSystem()
    {
        healthBarImage.fillAmount = (float)currentHealth / maxHealth;
        healthText.text = currentHealth + "/" + maxHealth;

        if (currentHealth <= 0)
        {
            Destroy(player.gameObject);
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       /* if (collision.gameObject.CompareTag("Player"))
        {
            currentHealth -= 1;
        }*/
    }
    
}
