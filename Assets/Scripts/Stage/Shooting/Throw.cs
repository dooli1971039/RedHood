using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    [SerializeField] GameObject m_goPrefab = null;
    [SerializeField] Transform m_tfRock = null;

    Camera m_cam = null;

    void Start()
    {
        m_cam = Camera.main;
    }

    void LookAtMouse()
    {
        Vector2 t_mousePos = m_cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 t_direction = new Vector2(t_mousePos.x - m_tfRock.position.x, t_mousePos.y - m_tfRock.position.y);

        m_tfRock.right = t_direction;
    }

    void TryThrow()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject t_rock = Instantiate(m_goPrefab, m_tfRock.position, m_tfRock.rotation);
            t_rock.GetComponent<Rigidbody2D>().velocity = t_rock.transform.right *12f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
        TryThrow();
    }
}
