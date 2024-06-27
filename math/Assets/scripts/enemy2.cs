using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public float speed = 2f; // 적의 이동 속도
    public float damage = 10f; // 적이 주는 데미지


    private Transform player; // 플레이어의 트랜스폼


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        // 플레이어를 향해 이동
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어에게 데미지 주기
            playerHealth.Instance.TakeDamage((int)damage);
            Destroy(gameObject);
        }
    }
}
