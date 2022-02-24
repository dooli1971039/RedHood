using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageUI : MonoBehaviour
{
    public Button ItemListButton; //아이템 목록 여는 버튼
    public GameObject ItemPanel; //아이템 목록의 회색창
    public GameObject[] Items = new GameObject[10]; //아이템: 0번부터 9번까지
    public Slider StageBar;
    public GameObject ButtonPanel;

    public void Awake()
    {   
        StageBar.value = Game.instance.barvalue;
    }

    public void OpenItemList() {
        ItemListButton.gameObject.SetActive(false);
        ItemPanel.gameObject.SetActive(true);

        for (int i = 0; i < 10; i++)
        { 
            if (Game.instance.itemList[i + 1] == 1)
            {
                Items[i].gameObject.SetActive(true);
            }
            else {
                Items[i].gameObject.SetActive(false); //장애물 건드렸을 때
            }
        }
    }

    public void CloseItemList() {
        ItemListButton.gameObject.SetActive(true);
        ItemPanel.gameObject.SetActive(false);
    }

    public void GoToStart() {
        
        SceneManager.LoadScene("Start");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Update()
    {
        if (Game.instance.stageIndex >= 2)
        {
            StageBar.value += 0.013f * Time.deltaTime; //체력바 증가

            if (StageBar.value >= Game.instance.stageIndex / 5.0f)
            {
                
                Time.timeScale = 0.0f; //게임 못 움직이게 일시정지
                ButtonPanel.gameObject.SetActive(true);
                Game.instance.soundCheck = false;
                SoundManager.instance.gameObject.SetActive(false);

                //start화면이나 restart 하면 무조건 초기화
                Game.instance.stageIndex = 1;
                StageBar.value = 0;
                Game.instance.barvalue = 0;
                for (int i = 0; i < 11; i++)
                {
                    Game.instance.itemList[i] = 0;
                }

            }

        }

    }

}
