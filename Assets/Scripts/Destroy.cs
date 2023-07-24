using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Update()
    {
        String leftObj = "Left(Clone)";
        String rightObj = "Right(Clone)";
        GameObject left = GameObject.Find(leftObj);
        GameObject right = GameObject.Find(rightObj);
        if (Input.GetKeyDown("left"))
        {
            if (left)
            {
                Destroy(left.gameObject);
            }
            //if (right)
            //{
            //    Debug.Log("GameOver");
            //}
        }
        if (Input.GetKeyDown("right"))
        {
            if (right)
            {
                Destroy(right.gameObject);
            }
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        //string[] myObjectsNames = new string[] { "Left(Clone)", "Right(Clone)" };
        //foreach(string myObjectName in myObjectsNames)
        //{
        //    GameObject go = GameObject.Find(myObjectName);
        //    if (go)
        //    {
        //        Destroy(go.gameObject);
        //    }
        //}
        //String leftObj = "Left(Clone)";
        //String rightObj = "Right(Clone)";
        //GameObject left = GameObject.Find(leftObj);
        //GameObject right = GameObject.Find(rightObj);
        //if (left)
        //{
        //    Destroy(left.gameObject);
        //}
        //if (right)
        //{
        //    Destroy(right.gameObject);
        //}
    }
}
