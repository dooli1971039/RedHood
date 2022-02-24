using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    static public Game instance;
    public int[] itemList = new int[11]; //0번은 아이템 개수, 그뒤로 아이템
    public int stageIndex = 1;
    public float barvalue = 0.0f;
    public bool soundCheck = true;


    public void NextStage()
    {
        stageIndex++;
    }

    private void Awake()
    {
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