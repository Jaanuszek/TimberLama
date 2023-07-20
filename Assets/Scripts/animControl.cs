using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControl : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")|| Input.GetKeyDown("right"))
        {
            player.GetComponent<Animator>().Play("ruchSiekiera");
        }
    }
}
