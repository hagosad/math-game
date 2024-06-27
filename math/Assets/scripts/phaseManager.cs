using System.Collections;
using System.Xml;
using UnityEngine;

public class phaseManager : MonoBehaviour
{
    // 싱글톤 인스턴스
    public static phaseManager Instance { get; private set; }

    // 게임의 현재 상태
    public enum GameState { Start, Boss2_1, Boss2_2, Boss2_3, Boss1, Boss2, End }
    public GameState CurrentState { get; private set; }

    [SerializeField] GameObject bnDefinition;
    [SerializeField] GameObject anbn;
    [SerializeField] GameObject[] a20s;
    [SerializeField] GameObject endcredit;
    [SerializeField] GameObject boss;
    private void Awake()
    {
        // 싱글톤 인스턴스 설정
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 삭제되지 않도록 설정
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스가 존재하면 새로운 인스턴스를 삭제
        }
    }

    private void Start()
    {
        ChangeState(GameState.Start);
    }

    // 게임 상태 변경 메서드
    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        switch (newState)
        {
            case GameState.Start:
                StartCoroutine(StartGame());
                break;
            case GameState.Boss2_1:
                dialogueManager.Instance.DisplayDialogue(" let's define an");
                break;
            case GameState.Boss2_2:
                dialogueManager.Instance.DisplayDialogue(" common difference of bn is double of an");
                StartCoroutine(Boss2_2());

                break;
            case GameState.Boss2_3:
                dialogueManager.Instance.DisplayDialogue(" Now we got a20 values, lets add them together.");
                break;
            case GameState.End:
                StartCoroutine(EndGame());
                break;
        }
    }

    IEnumerator Boss2_2()
    {
        yield return new WaitForSeconds(1f);
        bnDefinition.SetActive(true);
        yield return new WaitForSeconds(2f);
        Instantiate(anbn);
        dialogueManager.Instance.DisplayDialogue(" let's see what d can be");

    }

    IEnumerator EndGame()
    {
        boss.SetActive(false);
        yield return new WaitForSeconds(2);


        //끝연출

        endcredit.SetActive(true);


    }

    IEnumerator StartGame()
    {
        //시작 연출
        yield return null;


        ChangeState(GameState.Boss2_1);
    }
}
