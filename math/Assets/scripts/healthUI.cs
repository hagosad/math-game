using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshPro;
    void Start()
    {
        playerHealth.Instance.OnPlayerHealthChange += changeText;
    }

    private void changeText()
    {
        m_TextMeshPro.text = playerHealth.Instance.GetCurrentHealth().ToString();
    }

}
