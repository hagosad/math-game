using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnminustwo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject anDefine;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("-4"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            //phaseManager ¼³Á¤

            phaseManager.Instance.ChangeState(phaseManager.GameState.Boss2_2);
            Destroy(anDefine);
        }
    }
}
