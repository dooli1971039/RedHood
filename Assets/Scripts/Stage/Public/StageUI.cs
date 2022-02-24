using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageUI : MonoBehaviour
{
    public Button ItemListButton; //������ ��� ���� ��ư
    public GameObject ItemPanel; //������ ����� ȸ��â
    public GameObject[] Items = new GameObject[10]; //������: 0������ 9������
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
                Items[i].gameObject.SetActive(false); //��ֹ� �ǵ���� ��
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
            StageBar.value += 0.013f * Time.deltaTime; //ü�¹� ����

            if (StageBar.value >= Game.instance.stageIndex / 5.0f)
            {
                
                Time.timeScale = 0.0f; //���� �� �����̰� �Ͻ�����
                ButtonPanel.gameObject.SetActive(true);
                Game.instance.soundCheck = false;
                SoundManager.instance.gameObject.SetActive(false);

                //startȭ���̳� restart �ϸ� ������ �ʱ�ȭ
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
