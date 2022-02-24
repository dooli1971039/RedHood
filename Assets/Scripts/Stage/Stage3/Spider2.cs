using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider2 : MonoBehaviour
{
    Rigidbody2D rigid;
    public int nextMove;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, 0); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.flipY = (nextMove < 0);
        nextMove = -nextMove;
    }
}
