using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Conversation : MonoBehaviour
{
    float timer = 0f;
    public GameObject talkingPanel;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2.8f)
        {       
            talkingPanel.SetActive(true);
        }

        if(timer > 4.2f)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
