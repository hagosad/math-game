using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed = 5f;  // �÷��̾��� �̵� �ӵ�

    void Update()
    {
        // ���콺 ��ġ�� ���� ��ǥ�� ��ȯ
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Z�� ��ġ ���� (2D �����̹Ƿ�)

        // �÷��̾ ���콺�� ���ϵ��� ȸ��
        Vector3 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // �÷��̾ ���콺�� ���� �̵�
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
