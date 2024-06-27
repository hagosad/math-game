using UnityEngine;
using UnityEngine.UI;

public class CreditScript : MonoBehaviour
{
    public float scrollSpeed = 50f;  // 스크롤 속도 조절

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
