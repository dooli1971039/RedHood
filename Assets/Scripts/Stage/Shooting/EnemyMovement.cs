using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float rightMax = 6.0f; //�·� �̵������� (x)�ִ밪
    float leftMax = 0.0f; //��� �̵������� (x)�ִ밪
    float currentPosition; //���� ��ġ(x) ����
    float direction = 3.0f; //�̵��ӵ�+����
    float currentYPosition;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        currentPosition = transform.position.x;
        currentYPosition = transform.position.y;
        spriteRenderer = this.gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;
        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
            spriteRenderer.flipX = false;
        }
        //���� ��ġ(x)�� ��� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
        //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� ��� �̵������� (x)�ִ밪���� ����
        else if (currentPosition <= leftMax)
        {
            direction *= -1;
            currentPosition = leftMax;
            spriteRenderer.flipX = true;
        }
        //���� ��ġ(x)�� �·� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
        //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� �·� �̵������� (x)�ִ밪���� ����
        transform.position = new Vector3(currentPosition, currentYPosition, 0);
        //"Stone"�� ��ġ�� ���� ������ġ�� ó��
    }
}
