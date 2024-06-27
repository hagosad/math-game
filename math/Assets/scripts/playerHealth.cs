using System;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Singleton �ν��Ͻ� ����
    private static playerHealth instance;

    // �÷��̾� ü�� ���� ����
    private int maxHealth = 100;
    private int currentHealth;

    public Action OnPlayerHealthChange;

    // Singleton �ν��Ͻ� ��������
    public static playerHealth Instance
    {
        get
        {
            // �ν��Ͻ��� ������ ���� ����
            if (instance == null)
            {
                instance = FindObjectOfType<playerHealth>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<playerHealth>();
                    singletonObject.name = typeof(playerHealth).ToString() + " (Singleton)";
                }
            }
            return instance;
        }
    }

    void Awake()
    {
        // �ν��Ͻ��� �����ϰ� �����ǵ��� ����
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // �׽�Ʈ�� ���� �ʱ� ü�� ����
        currentHealth = maxHealth;
        OnPlayerHealthChange?.Invoke();
    }


    // ü���� ���ҽ�Ű�� �޼���
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
        OnPlayerHealthChange?.Invoke();
    }

    // ü���� ȸ����Ű�� �޼���
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        OnPlayerHealthChange?.Invoke();
    }

    // �÷��̾ ������� �� ȣ��Ǵ� �޼��� (��: ���� ���� ó��)
    private void Die()
    {
        Debug.Log("Player has died!");
        // �߰����� ��� ó�� ������ ���⿡ �߰��� �� �ֽ��ϴ�.
    }

    // ���� ü�� ��������
    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    // �ִ� ü�� ��������
    public int GetMaxHealth()
    {
        return maxHealth;
    }
}