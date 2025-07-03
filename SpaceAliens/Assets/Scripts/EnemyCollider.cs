using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] int damageAmount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(collision.gameObject.name);

        PlayerDamage damagedObject = collision.gameObject.GetComponent<PlayerDamage>(); //reference to damage the object

        if (damagedObject != null)
        {
            damagedObject.DealDamage(damageAmount); //damaging object hit
            FindObjectOfType<AudioManager>().Play("LivesLost");

        }
    }
}
