using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingUI : MonoBehaviour
{
    public GameObject[] e_Items = new GameObject[10];
    // public int[] example = new int[] { 2, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };

    public void ShowItemList()
    {
        GameObject.FindWithTag("¸»Ç³¼±1").SetActive(false);
        GameObject.FindWithTag("¸»Ç³¼±2").SetActive(false);
        GameObject.FindWithTag("basic").SetActive(false);

        for (int i = 0; i < 10; i++)
        {
            if (Game.instance.itemList[i + 1] == 1)
            {
                e_Items[i].gameObject.SetActive(true);
            }
            else
            {
                e_Items[i].gameObject.SetActive(false);
            }
        }
    }
}
