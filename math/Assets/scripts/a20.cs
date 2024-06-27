using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a20 : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Sprite spr;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("a20"))
        {
            Destroy(collision.gameObject);
            phaseManager.Instance.ChangeState(phaseManager.GameState.End);
            ChangeState();
        }
    }
    private void ChangeState()
    {
        sr.sprite = spr;
        transform.position = new Vector2(3.8f, -2.7f);
    }
}
