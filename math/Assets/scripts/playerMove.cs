using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed = 5f;  // 플레이어의 이동 속도

    void Update()
    {
        // 마우스 위치를 월드 좌표로 변환
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Z축 위치 고정 (2D 게임이므로)

        // 플레이어가 마우스를 향하도록 회전
        Vector3 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // 플레이어가 마우스를 향해 이동
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
