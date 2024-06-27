using UnityEngine;

public class Boss2 : MonoBehaviour
{
    public GameObject enemyPrefab; // ������ ���� ������
    public Transform spawnPoint; // ���� ������ ��ġ
    public float spawnInterval = 10f; // �� ���� ����

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
