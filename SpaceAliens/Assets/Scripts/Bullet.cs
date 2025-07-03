using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(collision.gameObject.name);

        Enemies damagedObject = collision.gameObject.GetComponent<Enemies>(); //reference to damage the object

        if (damagedObject != null)
        {
            damagedObject.DealDamage(damageAmount); //damaging object hit
            FindObjectOfType<AudioManager>().Play("EnemyDamaged");
//          GameManager.AddScore(5);


            Destroy(gameObject);
        }
    }
}
