using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int maxSpawn;
    public List<GameObject> enemyList;
    public int spawnTime;
    public Clone clone;

    private void Start()
    {
        for (int i = 0; i <= maxSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-77f, 125f), 5f, Random.Range(-118f, 64f));
            GameObject NewInst = Instantiate(enemy, randomPos, Quaternion.identity);
            enemyList.Add(NewInst);
        }
        InvokeRepeating("Spawn", 2f, spawnTime);
        clone = FindObjectOfType<Clone>();
    }

    private void Spawn()
    {
        spawnTime = clone.spawnTime;
        Vector3 randomPos = new Vector3(Random.Range(-77f, 125f), 5f, Random.Range(-118f, 64f));
        GameObject newEnemy = Instantiate(enemy, randomPos, Quaternion.identity);
    }
}
