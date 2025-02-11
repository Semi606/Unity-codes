using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnRate);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(10, Random.Range(-3f, 3f), 0);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
