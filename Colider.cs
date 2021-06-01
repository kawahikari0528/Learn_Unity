using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Colider : MonoBehaviour
{
    public GameObject WinMessage,player;
    public GameObject WinLine,QuitButton,ReStartButton, player1, player2;
    private Vector3 witch;
    // Start is called before the first frame update
    void Start()
    {
        witch = this.transform.position;
        print(player1);
    }

    public void Process(GameObject ToWin)
    {
        ReStartButton.SetActive(true);
        QuitButton.SetActive(true);
        ToWin.SetActive(true);
        player1.SetActive(false);
        player2.SetActive(false);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        print(other.gameObject.name);
        if (WinLine.name == other.gameObject.name)
        {
            Process(WinMessage);
        }
        else
        {
            transform.position = new Vector3(witch.x, witch.y, witch.z);
        }


    }
    // Update is called once per frame

}
