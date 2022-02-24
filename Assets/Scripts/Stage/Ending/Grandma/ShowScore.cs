using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public GameObject[] score_list = new GameObject[11];
    // public int[] example = new int[] { 2, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };

    public void ShowScoreList()
    {
        for (int i = 0; i < 11; i++)
        {
            if (Game.instance.itemList[0] == i)
            {
                score_list[i].gameObject.SetActive(true);
            }
            else
            {
                score_list[i].gameObject.SetActive(false);
            }
        }
    }
}
