using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject EnemyPrefab; //Enemy Prefab
    public float spawnInterval;    //Interval between each spawn

    //Spawn Area//
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    void Start()
    {
        StartCoroutine(WaitAndSpawn(spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            Vector3 SpawnPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));

            Instantiate(EnemyPrefab, SpawnPosition, Quaternion.identity);
        }
    }

}
