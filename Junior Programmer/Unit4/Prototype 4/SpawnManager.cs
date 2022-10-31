using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    private int enemies;
    private int wave = 1;
    
    public GameObject powerupPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(wave);
        Instantiate(powerupPrefab, SpawnPos(), powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemies = FindObjectsOfType<Enemy>().Length;
    
        if (enemies == 0)
        {
            wave++;
            SpawnEnemyWave(wave);
            Instantiate(powerupPrefab, SpawnPos(), powerupPrefab.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemies)
    {
       for (int i = 0; i < enemies; i++)
        {
            Instantiate(enemyPrefab, SpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 SpawnPos()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        return spawnPos;
    }
}
