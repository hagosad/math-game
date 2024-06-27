using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bn : MonoBehaviour
{
    [SerializeField] GameObject[] gameobjects;
    private int mode = 0;
    [SerializeField] GameObject anbn;
    private void Update()
    {
        Debug.Log(transform.position.y);
        switch (mode)
        {
            
            case 0:
                if(transform.position.y > 3)
                {
                    mode = 1;
                }
                break;
            case 1:
                if (transform.position.y > 6.5f)
                {
                    mode = 2;
                    GameObject go = Instantiate(gameobjects[0], transform); 
                    go.transform.SetParent(phaseManager.Instance.transform);
                    go.transform.position = new Vector3(4, 0, 0);
                }
                break;
            case 2:
                if (transform.position.y > 9.5f)
                {
                    GameObject  go= Instantiate(gameobjects[1], transform);
                    go.transform.SetParent(phaseManager.Instance.transform);
                    go.transform.position = new Vector3(0, 0, 0);

                    //다음페이즈

                    phaseManager.Instance.ChangeState(phaseManager.GameState.Boss2_3);
                    Destroy(anbn);
                }
                break;
        }
    }
}
