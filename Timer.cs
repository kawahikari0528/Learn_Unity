using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : Colider
{
    // Start is called before the first frame update
    public GameObject player1, player2;
    public Text timer;
    private float time = 10;
    private Vector3 witch2;
    // Start is called before the first frame update
    void Start()
    {
        witch2 = this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = Mathf.Ceil(time).ToString();
        if (Input.GetKey(KeyCode.W) && time < 5) 
        {
            time = 5;
        }
        if (Input.GetKey(KeyCode.I) && time < 5) 
        {
            time = 5;
        }
        if (time < 0)
        {
            time = 7;
            player1.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);
            player2.transform.position = new Vector3(witch2.x, witch2.y, witch2.z);
        }

    }
}
