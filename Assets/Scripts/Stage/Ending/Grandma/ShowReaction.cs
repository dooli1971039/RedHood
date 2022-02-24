using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowReaction : MonoBehaviour
{
    // public int[] example = new int[] { 2, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
    public GameObject[] reaction_list = new GameObject[3];
    [SerializeField]
    public GameObject button1;  // 다음
    [SerializeField]
    public GameObject button2;  // 게임종료
    [SerializeField]
    public GameObject button3;  // 다시하기

    public void grandmaReaction()
    {
        // GameObject.FindWithTag("Finish").SetActive(true);
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(true);

        if (Game.instance.itemList[0] >= 0 & Game.instance.itemList[0] < 4)
        {
            reaction_list[0].gameObject.SetActive(true);
            button3.gameObject.SetActive(true);

        }
        else if (Game.instance.itemList[0] >= 4 & Game.instance.itemList[0] < 8)
        {
            reaction_list[1].gameObject.SetActive(true);
        }
        else
        {
            reaction_list[2].gameObject.SetActive(true);
        }
        
    }
}
