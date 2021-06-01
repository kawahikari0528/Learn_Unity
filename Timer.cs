using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Timer : MonoBehaviour
{


    public struct PlayerControl
    {
        public GameObject player;
        public int LastMove, LoseCount;
    }
 
    public Text timer;
    private float time = 10;
    private Vector3 witch2;
    public  GameObject WinMessage1, WinMessage2, QuitButton, ReStartButton;

    public void Process(GameObject ToWin)
    {
        ReStartButton.SetActive(true);
        QuitButton.SetActive(true);
        ToWin.SetActive(true);
        p1.player.SetActive(false);
        p2.player.SetActive(false);
    }
    public  void Use(GameObject gameObject, int Count)
    {

        if (Count == 2)
        {
            if (gameObject == p1.player)
            {
                Process(WinMessage1);
            }
            else if (gameObject == p2.player)
            {

                Process(WinMessage2);
            }
        }
        
    }

    void TheLateMove()
    {
        if (Input.GetKey(KeyCode.W) && time < 5)
        {
            time = 5;
            p1.LastMove = 1;
            p2.LastMove = 0;//LastMove: 마지막으로 움직인 플레이어 판별
        }
        if (Input.GetKey(KeyCode.I) && time < 5)
        {
            time = 5;
            p2.LastMove = 1;
            p1.LastMove = 0;
        }
        if (time < 0)
        {
            time = 7;
            p1.player.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);
            p2.player.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);

            if (p1.LastMove == 0)
            {
                if (p2.LoseCount == 1) p1.LoseCount = 0;
                p1.LoseCount++;
            }
            else if (p2.LastMove == 0)
            {
                if (p1.LoseCount == 1) p2.LoseCount = 0;
                p2.LoseCount++;
            }//LostCount 증감
            else { };
            print("P1 LoseCount" + p1.LoseCount);
            print("P2 LoseCount" + p2.LoseCount);
            if (p1.LoseCount == 2)
            {
                Process(WinMessage2);
            }
            else if(p2.LoseCount == 2)
            {
                Process(WinMessage1);
            }
        }
    }


    public PlayerControl p1;
    public PlayerControl p2;
    

    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        witch2 = this.transform.position;
        p1.LastMove = 0;
        p2.LastMove = 0;
        p1.player = GameObject.Find("Player1");
        p2.player = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = Mathf.Ceil(time).ToString();


        TheLateMove();//타이머가 0 이하가 되면 양 플레이어의 위치 초기화, 마지막으로 움직이지 않은 플레이어에게 LoseCount +1
    }
}
