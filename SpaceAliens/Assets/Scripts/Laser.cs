using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Rigidbody2D bullet;
    [SerializeField] float bulletSpeed = 9f;
    float offsetX = 0f;
    [SerializeField] float offsetY = 0.2f;

    [Range(0.01f, 0.5f)]
    [SerializeField] float autoFireDelay = 0.3f;
    float autoFireTimer = 0f;

    [SerializeField] bool spreadShot = true;
    [SerializeField] float spreadShotDelay = 10f;
    float spreadShotTimer = 0f;
    float bulletAngle = 0f;
    float bulletAngleOffset = 0.5f;

    void Start()
    {

    }

    void Update()
    {
        // FireWeapon();
        AutoFire();

        if (spreadShot)
        {
            SpreadShot();
        }
    }

    void FireWeapon()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireShot();
        }
    }

    void AutoFire()
    {
        autoFireTimer += Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            if (autoFireTimer > autoFireDelay)
            {
                FireShot();
                autoFireTimer = 0f;
            }
        }
    }

    void FireShot()
    {
        Rigidbody2D shot;
        shot = Instantiate(bullet, transform.position + new Vector3(offsetX, offsetY, 0f), transform.rotation);
        shot.velocity = new Vector3(bulletAngle - bulletAngleOffset, 1.0f, 0f) * bulletSpeed;
    }

    void SpreadShot()
    {
        spreadShotTimer += Time.deltaTime;

        if (spreadShotTimer > spreadShotDelay)
        {
            bulletAngle = (bulletAngle + 0.1f)% 1F;
            spreadShotTimer = 0f;
        }
    }
}
