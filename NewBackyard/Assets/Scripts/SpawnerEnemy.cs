using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int maxSpawn;
    public List<GameObject> enemyList;
    public int spawnTime;
    public CloneEnemy clone;

    private void Start()
    {
        for (int i = 0; i <= maxSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-84f, 120f), 5f, Random.Range(-6f, -60f));
            GameObject NewInst = Instantiate(enemy, randomPos, Quaternion.identity);
            enemyList.Add(NewInst);
        }
        InvokeRepeating("Spawn", 2f, spawnTime);
        clone = FindObjectOfType<CloneEnemy>();
    }

    private void Spawn()
    {
        spawnTime = clone.spawnTime;
        Vector3 randomPos = new Vector3(Random.Range(-84f, 120f), 5f, Random.Range(-6f, -60f));
        GameObject newEnemy = Instantiate(enemy, randomPos, Quaternion.identity);
    }
}
