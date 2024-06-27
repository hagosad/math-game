using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;  // ��縦 ǥ���� �ؽ�Ʈ UI ���
    public float typingSpeed = 0.02f;  // Ÿ���� �ӵ�
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
        dialogueText.text = "";  // ������ �� ��縦 �� ���ڿ��� �ʱ�ȭ
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
