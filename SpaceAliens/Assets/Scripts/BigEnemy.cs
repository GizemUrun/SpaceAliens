using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : EnemyManager
{
    public override void SpawnEnemy()
    {
        spawnXMin = -3f;
        spawnXMax = 11f;
        spawnWidth = 3f;
        float spawnX = (Random.Range(spawnXMin, spawnXMax) * spawnWidth);
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(spawnX, 0f, 0f), transform.rotation);

    }

}
