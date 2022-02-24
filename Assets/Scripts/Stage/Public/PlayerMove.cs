using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float maxSpeed=3.0f;
    Vector2 origin;
    public Slider StageBar;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        origin = transform.position;

        if (Game.instance.soundCheck == false && Game.instance.stageIndex == 1)
        {
            Game.instance.soundCheck = true;
            SoundManager.instance.gameObject.SetActive(true);
        }

        if (Time.timeScale == 0.0f) Time.timeScale = 1.0f;
    }



    void Update()
    {   
        //stop speed
        if (Input.GetButtonUp("Horizontal"))  //좌우
        {
            //scale 1 vector
            rigid.velocity = new Vector2(0, rigid.velocity.y);
        }
        if (Input.GetButtonUp("Vertical"))  //상하
        {
            //scale 1 vector
            rigid.velocity = new Vector2(rigid.velocity.x, 0);
        }

    }

    void FixedUpdate() {

        //Move By key Control
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rigid.AddForce(Vector2.right * x, ForceMode2D.Impulse);
        rigid.AddForce(Vector2.up * y, ForceMode2D.Impulse);

        //max speed :X
        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < (-1) * maxSpeed)
            rigid.velocity = new Vector2((-1) * maxSpeed, rigid.velocity.y);

        //max speed :Y
        if (rigid.velocity.y > maxSpeed)
            rigid.velocity = new Vector2(rigid.velocity.x, maxSpeed);
        else if (rigid.velocity.y < (-1) * maxSpeed)
            rigid.velocity = new Vector2(rigid.velocity.x, (-1) * maxSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //충돌
        if (collision.gameObject.tag == "Enemy") 
        {   
            /* 스테이지 처음 위치로 이동 */
            transform.position = origin;
        }


        //아이템 획득
        if (collision.gameObject.tag == "Item") {
            //Deactive Item
            collision.gameObject.SetActive(false);

            //Get Item <--함수로 목록 만들어서 어떤 아이템을 얻었는지 체크
            GetItem(collision);

            Game.instance.itemList[0] += 1; //아이템 개수 증가
        }


        //스테이지 끝
        if (collision.gameObject.tag == "Finish") {
            Game.instance.NextStage();
            if (Game.instance.stageIndex <=5 ) { //스테이지 5까지
                Game.instance.barvalue = StageBar.value;
                SceneManager.LoadScene("Stage" + Game.instance.stageIndex); //다음 스테이지로
            }
            if (Game.instance.stageIndex == 6)
            {
                Game.instance.soundCheck = false;
                SoundManager.instance.gameObject.SetActive(false);
                SceneManager.LoadScene("WolfEnding");
            }
        }
    }


    void GetItem(Collider2D collision) { //아이템 목록 체크

        if (collision.gameObject.name == "butterscotch")   //stage1
        {
            Game.instance.itemList[1] = 1; //아이템 획득
        }
        if (collision.gameObject.name == "banana")     //stage1
        {
            Game.instance.itemList[2] = 1; //아이템 획득
        }


        if (collision.gameObject.name == "Milk")     //stage2
        {
            Game.instance.itemList[3] = 1; //아이템 획득
        }
        if (collision.gameObject.name == "Cupcake")     //stage2
        {
            Game.instance.itemList[4] = 1; //아이템 획득
        }


        if (collision.gameObject.name == "macaroon")   //stage3
        {
            Game.instance.itemList[5] = 1; //아이템 획득
        }
        if (collision.gameObject.name == "coffee")     //stage3
        {
            Game.instance.itemList[6] = 1; //아이템 획득
        }


        if (collision.gameObject.name == "Sandwich")     //stage4
        {
            Game.instance.itemList[7] = 1; //아이템 획득
        }
        if (collision.gameObject.name == "Icecream")     //stage4
        {
            Game.instance.itemList[8] = 1; //아이템 획득
        }


        if (collision.gameObject.name == "thread")     //stage5
        {
            Game.instance.itemList[9] = 1; //아이템 획득
        }
        if (collision.gameObject.name == "book")     //stage5
        {
            Game.instance.itemList[10] = 1; //아이템 획득
        }

    }
}
