using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public float speed = 2f; // ���� �̵� �ӵ�
    public float damage = 10f; // ���� �ִ� ������


    private Transform player; // �÷��̾��� Ʈ������


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        // �÷��̾ ���� �̵�
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
            // �÷��̾�� ������ �ֱ�
            playerHealth.Instance.TakeDamage((int)damage);
            Destroy(gameObject);
        }
    }
}
