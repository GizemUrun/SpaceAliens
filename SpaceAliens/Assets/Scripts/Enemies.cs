using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] int health = 4;
    [SerializeField] int s;

    private void Start()
    {
      //s = FindObjectOfType<Score>();
    }

    public void DealDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0)
        {
      //    Score.AddScore(s);

            Destroy(gameObject);
            
        }
    }
}
