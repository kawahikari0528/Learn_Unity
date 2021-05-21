using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public void AppExit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
