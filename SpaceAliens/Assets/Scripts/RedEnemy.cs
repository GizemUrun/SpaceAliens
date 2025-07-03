using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : EnemyManager
{
    public override void SpawnEnemy()
    {
        spawnXMin = -5f;
        spawnXMax = 10f;
        spawnWidth = 1f;
        float spawnX = (Random.Range(spawnXMin, spawnXMax) * spawnWidth);
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(spawnX, 0f, 0f), transform.rotation);

    }

}
