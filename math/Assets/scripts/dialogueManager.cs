using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;  // 대사를 표시할 텍스트 UI 요소
    public float typingSpeed = 0.02f;  // 타이핑 속도
    private static dialogueManager instance;
    public static dialogueManager Instance {  get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }
    void Start()
    {
        dialogueText.text = "";  // 시작할 때 대사를 빈 문자열로 초기화
    }

    public void DisplayDialogue(string dialogue)
    {
        StartCoroutine(TypeDialogue(dialogue));
    }

    IEnumerator TypeDialogue(string dialogue)
    {
        dialogueText.text = "";
        foreach (char letter in dialogue.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void ClearDialogue()
    {
        dialogueText.text = "";
    }
}
