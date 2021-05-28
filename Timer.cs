using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Timer : MonoBehaviour
{

    
    public struct PlayerControl
    {
        public int LastMove, LoseCount;
    }
 
    public Text timer;
    private float time = 10;
    private Vector3 witch2;
    public GameObject WinMessage1, WinMessage2;
    public GameObject player1, player2;
    public class WinRule : Colider
    {
        
        public  void Use(GameObject gameObject, int Count)
        {

            if (Count == 2)
            {
                if (gameObject == player1)
                {
                    Process(WinMessage1);
                }
                else if (gameObject == player2)
                {

                    Process(WinMessage2);
                }
            }
        }

        private void OnCollisionEnter2D()
        {
            throw new NotImplementedException();
        }
    }
    void TheLateMove()
    {
        if (Input.GetKey(KeyCode.W) && time < 5)
        {
            time = 5;
            p1.LastMove = 1;
            p2.LastMove = 0;//LastMove: ���������� ������ �÷��̾� �Ǻ�
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
            player1.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);
            player2.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);

            if (p1.LastMove == 0)
            {
                if (p2.LoseCount == 1) p1.LoseCount = 0;
                p1.LoseCount++;
            }
            else if (p2.LastMove == 0)
            {
                if (p1.LoseCount == 1) p2.LoseCount = 0;
                p2.LoseCount++;
            }//LostCount ����
            else { };
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
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = Mathf.Ceil(time).ToString();


        TheLateMove();//Ÿ�̸Ӱ� 0 ���ϰ� �Ǹ� �� �÷��̾��� ��ġ �ʱ�ȭ, ���������� �������� ���� �÷��̾�� LoseCount +1
    }
}
