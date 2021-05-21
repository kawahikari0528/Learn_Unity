using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    public Text Scripttext;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player1") 
        Scripttext.text = "1p½Â¸®";
        else
        Scripttext.text = "2p½Â¸®";
    }
    // Update is called once per frame
}
