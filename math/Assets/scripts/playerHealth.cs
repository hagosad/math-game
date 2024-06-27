using System;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Singleton 인스턴스 변수
    private static playerHealth instance;

    // 플레이어 체력 관련 변수
    private int maxHealth = 100;
    private int currentHealth;

    public Action OnPlayerHealthChange;

    // Singleton 인스턴스 가져오기
    public static playerHealth Instance
    {
        get
        {
            // 인스턴스가 없으면 새로 생성
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
        // 인스턴스가 유일하게 유지되도록 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // 테스트를 위해 초기 체력 설정
        currentHealth = maxHealth;
        OnPlayerHealthChange?.Invoke();
    }


    // 체력을 감소시키는 메서드
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
        OnPlayerHealthChange?.Invoke();
    }

    // 체력을 회복시키는 메서드
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        OnPlayerHealthChange?.Invoke();
    }

    // 플레이어가 사망했을 때 호출되는 메서드 (예: 게임 오버 처리)
    private void Die()
    {
        Debug.Log("Player has died!");
        // 추가적인 사망 처리 로직을 여기에 추가할 수 있습니다.
    }

    // 현재 체력 가져오기
    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    // 최대 체력 가져오기
    public int GetMaxHealth()
    {
        return maxHealth;
    }
}