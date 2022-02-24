using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    static public Game instance;
    public int[] itemList = new int[11]; //0���� ������ ����, �׵ڷ� ������
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