using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redo : MonoBehaviour
{
    public void OnMouseDownRedo()
    {
        Game.instance.stageIndex = 1;
        Game.instance.barvalue = 0;
        for (int i = 0; i < 11; i++)
        {
            Game.instance.itemList[i] = 0;
        }
        SceneManager.LoadScene("Stage1");
    }
}
