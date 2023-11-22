using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int maxSpawn;
    public List<GameObject> enemyList;
    public int spawnTime;

    private void Start()
    {
        for (int i = 0; i <= maxSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-555f, 800f), -190f, Random.Range(-700f,500f));
            GameObject NewInst = Instantiate(enemy, randomPos, Quaternion.identity);
            enemyList.Add(NewInst);
        }
        InvokeRepeating("Spawn", 2f,spawnTime);
    }

    private void Spawn()
    {
        Vector3 randomPos = new Vector3(Random.Range(-555f, 800f), -190f, Random.Range(-700f,500f));
        GameObject newEnemy = Instantiate(enemy, randomPos, Quaternion.identity);
    }
    
}
