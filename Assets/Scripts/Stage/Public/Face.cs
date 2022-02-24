using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject ButtonPanel;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (ButtonPanel.activeSelf) {
            sr.material.color = new Color(1,1,1,0.3f);
        }
    }
}
