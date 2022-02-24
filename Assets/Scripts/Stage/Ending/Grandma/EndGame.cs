using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Update is called once per frame
    public void OnMouseDown()
    {
        Application.Quit();
    }

    /*
    public void GameQuit()
    {
        Application.Quit();
    }
    */
}
