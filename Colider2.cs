using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colider2 : MonoBehaviour
{
    public GameObject line;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        this.gameObject.SetActive(false);

    }
}
