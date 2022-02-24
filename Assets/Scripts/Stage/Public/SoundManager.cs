using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static public SoundManager instance;
    public AudioSource audioSource;
    GameObject StartSound;

    private void Awake()
    {
        StartSound = GameObject.Find("StartBGM");
        GameObject.Destroy(StartSound);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { 
            Destroy(this.gameObject);
        }
    }

}
