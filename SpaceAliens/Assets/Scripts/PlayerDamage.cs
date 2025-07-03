using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int health = 5;
    public int numHearts = 5;

    

    [SerializeField] Image[] hearts;
    [SerializeField] Sprite emptyHeart;
    [SerializeField] Sprite fullHeart;

    public PlayerDamage(int health, int numHearts)
    {
        Health = health;
        NumHearts = numHearts;
    }

    public int Health
    {
        get { return health; } //read
        set
        {
            if(value > 6)
            {
                health = 5;
            }
        }
    }

    public int NumHearts
    {
        get { return numHearts; } //read
        set
        {
            if (value > 6)
            {
                numHearts = 5;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(health > numHearts)
        {
            health = numHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
                
            if(i < numHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void DealDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0)
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("GameOver");

            SceneManager.LoadScene("GameOver");


        }
    }
}
