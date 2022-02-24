using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeePath : MonoBehaviour
{
    [SerializeField] Transform[] pathPos;
    [SerializeField] float speed = 5f;
    int pathNum = 0;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pathPos[pathNum].transform.position;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePath();
    }

    public void MovePath()
    {
        transform.position = Vector2.MoveTowards
            (transform.position, pathPos[pathNum].transform.position, speed * Time.deltaTime);

        if(pathNum == 1)
        {
            sr.flipX = true;
        }

        if (pathNum == 2)
        {
            sr.flipX = false;
        }
        if (pathNum == 0)
        {
            sr.flipX = true;
        }

        if (pathNum == 3)
        {
            sr.flipX = false;
        }

        if (transform.position == pathPos[pathNum].transform.position)
        {
            pathNum++;
        }

        if (pathNum == pathPos.Length)
        {
            pathNum = 0;
        }

     
  

    }
}
