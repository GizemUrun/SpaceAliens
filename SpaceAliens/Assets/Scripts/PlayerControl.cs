using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    float hDirection;
    float vDirection;
    Rigidbody2D playerRigidbody;

    void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hDirection = Input.GetAxisRaw("Horizontal");
        vDirection = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector2(hDirection * moveSpeed, vDirection * moveSpeed); //movement of player
    }
}
