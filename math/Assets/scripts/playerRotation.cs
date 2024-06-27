using UnityEngine;

public class playerRotation : MonoBehaviour
{
    void Update()
    {
        // ���콺 ��ġ ��������
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // 2D ȯ���̹Ƿ� z ���� 0���� ����

        // �÷��̾� ��ġ ��������
        Vector3 playerPosition = transform.position;

        // ���콺 ��ġ���� ���� ���� ���
        Vector3 direction = mousePosition - playerPosition;

        // ȸ�� ���� ���
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // �÷��̾� ȸ�� ����
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}