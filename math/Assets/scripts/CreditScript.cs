using UnityEngine;
using UnityEngine.UI;

public class CreditScript : MonoBehaviour
{
    public float scrollSpeed = 50f;  // ��ũ�� �ӵ� ����

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
    }
}
