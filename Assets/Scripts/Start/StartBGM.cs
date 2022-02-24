using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBGM : MonoBehaviour
{
    public static StartBGM Instance;    
    public AudioSource backmusic;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }        

    }

    public void DestroyMusic()
    {
        backmusic.Stop();
    }
}
