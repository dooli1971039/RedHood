using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    public GameObject endingscene;
    [SerializeField]
    public GameObject button;
    [SerializeField]
    public GameObject slider;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        // 타격 된거 잠깐 색 바꿔서 알리기
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if (currentHP <= 0)
        {
            // Debug.Log("Enemy HP : 0.. Die");
            Destroy(gameObject);
            endingscene.gameObject.SetActive(true);
            button.gameObject.SetActive(true);
            slider.gameObject.SetActive(false);
            // SceneManager.LoadScene("GrandmaScore");

        }
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }
}