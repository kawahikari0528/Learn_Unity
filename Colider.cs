using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Colider : Timer
{
    public GameObject player;
    public GameObject WinMessage;
    public static GameObject WinLine,QuitButton,ReStartButton;
    private Vector3 witch;
    // Start is called before the first frame update
    void Start()
    {
        witch = this.transform.position;
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
            Process(WinLine);
        }
        else
        {
            transform.position = new Vector3(witch.x, witch.y, witch.z);
        }


    }
    // Update is called once per frame

}
