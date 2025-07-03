using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] protected GameObject enemyBlueprint;
    protected float spawnTimer = 0f;
    [SerializeField] protected float spawnDelay =0.2f;

    protected float spawnXMin = -4f;
    protected float spawnXMax = 10f;

    [SerializeField] protected float spawnWidth = 1f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > spawnDelay)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }


    public virtual void SpawnEnemy()
    {
        float spawnX = (Random.Range(spawnXMin, spawnXMax) * spawnWidth);
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(spawnX, 0f, 0f), transform.rotation);
    }
}
