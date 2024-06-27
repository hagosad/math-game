using UnityEngine;

public class Boss2 : MonoBehaviour
{
    public GameObject enemyPrefab; // 스폰할 적의 프리팹
    public Transform spawnPoint; // 적이 스폰될 위치
    public float spawnInterval = 10f; // 적 스폰 간격

    private float spawnTimer;

    void Start()
    {
        spawnTimer = 20f;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            SpawnEnemy();
            spawnTimer = spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
