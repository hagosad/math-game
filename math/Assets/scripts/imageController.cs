using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageController : MonoBehaviour
{
    [SerializeField] Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(controlImage());
    }

    

    IEnumerator controlImage()
    {
        yield return new WaitForSeconds(10f);
        image.rectTransform.anchoredPosition = new Vector3(344.6359f, 152.3854f, 0);
        image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 191.9284f);
        image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 109.2288f);

    }
}
