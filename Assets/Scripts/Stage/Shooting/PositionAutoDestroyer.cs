using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    private float destroyWeight = 2.0f;
    private float limitMinX = -5.0f;
    private float limitMinY = -4.0f;
    private float limitMaxX = 7.0f;
    private float limitMaxY = 3.0f;

    private void LateUpdate()
    {
        if (transform.position.y < limitMinY - destroyWeight ||
           transform.position.y > limitMaxY + destroyWeight ||
           transform.position.x < limitMinX - destroyWeight ||
           transform.position.x > limitMaxX + destroyWeight)
        {
            Destroy(gameObject);
        }
    }
}
