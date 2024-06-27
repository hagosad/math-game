using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusfour : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("an"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
