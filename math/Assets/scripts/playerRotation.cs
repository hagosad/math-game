using UnityEngine;

public class playerRotation : MonoBehaviour
{
    void Update()
    {
        // 마우스 위치 가져오기
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // 2D 환경이므로 z 축을 0으로 설정

        // 플레이어 위치 가져오기
        Vector3 playerPosition = transform.position;

        // 마우스 위치로의 방향 벡터 계산
        Vector3 direction = mousePosition - playerPosition;

        // 회전 각도 계산
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 플레이어 회전 설정
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}