using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    int rand;

    float randX;
    float randY;
    float xWidth;
    float yHeight;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    static int maxEnemy = 4;
    static float enemyCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(enemyCount < maxEnemy)
        {
            nextSpawn = Time.time + spawnRate;
            xWidth = (Screen.width - 32) / 100;
            yHeight = (Screen.height - 32) / 100;
            randX = Random.Range(-xWidth, xWidth);
            randY = Random.Range(-yHeight, yHeight);
            whereToSpawn = new Vector2(randX, randY);
            if(Random.Range(0,2)==0)
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            else
             if (Random.Range(0,2)== 1)
                Instantiate(enemy2, whereToSpawn, Quaternion.identity);
            else
                Instantiate(enemy3, whereToSpawn, Quaternion.identity);
            enemyCount++;
        }
    }
}
