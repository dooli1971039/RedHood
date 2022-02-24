using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    Rigidbody2D rigid;
    public int nextMove;
    Animator anim;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        rigid.velocity = 0.75f * new Vector2(nextMove,0); //왼쪽으로 먼저 이동
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.flipX = (nextMove < 0);
        nextMove = -nextMove;
    }
}
