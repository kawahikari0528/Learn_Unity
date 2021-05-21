using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    public GameObject player;
    public GameObject WinMessage;
    public GameObject WinLine,QuitButton,ReStartButton;
    private Vector3 witch;
    // Start is called before the first frame update
    void Start()
    {
        witch = this.transform.position;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        print(other.gameObject.name);
        if (WinLine.name == other.gameObject.name)
        {
            ReStartButton.SetActive(true);
            QuitButton.SetActive(true);
            WinMessage.SetActive(true);
            this.gameObject.SetActive(false);
            player.SetActive(false);
        }
        else
        {
            transform.position = new Vector3(witch.x, witch.y, witch.z);
        }


    }
    // Update is called once per frame

}
