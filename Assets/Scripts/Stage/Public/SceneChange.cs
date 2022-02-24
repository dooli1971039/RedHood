using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void StartGame()
    {       
        SceneManager.LoadScene("Stage1");
    }

    public void GoHowTo()
    {
        SceneManager.LoadScene("HowTo");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void BGM1() {
        SceneManager.LoadScene("BGM1");
    }

    public void BGM2()
    {
        SceneManager.LoadScene("BGM2");
    }
}
