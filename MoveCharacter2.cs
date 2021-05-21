using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.position = this.transform.position + new Vector3(0, 2, 0) * Time.deltaTime;
        }
    }
}
