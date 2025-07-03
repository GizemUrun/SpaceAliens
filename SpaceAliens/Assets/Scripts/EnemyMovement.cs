using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D enemyRigidbody;
    //float hDirection = 0f;
    float vDirection = -1f;

    float oscillator;
    float timer;
    float amplitude = 2f;
    [SerializeField] float period = 5.75f;
    float phase = 0f;
    float hShift = 0f;


    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = gameObject.GetComponent<Rigidbody2D>();
        phase = Random.Range(-15f, 15f);
        hShift = Random.Range(-15f, 15f);
    }

    private void Update()
    {
        OscillatorCalc();
    }

    void OscillatorCalc()
    {
        timer += Time.deltaTime;
        oscillator = (amplitude * Mathf.Sin(((2 * Mathf.PI) / period) * (timer + phase))) + hShift;
    }

    private void FixedUpdate()
    {
        enemyRigidbody.velocity = new Vector2(oscillator, vDirection * moveSpeed); //movement of player
    }
}
