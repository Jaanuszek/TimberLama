using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class objSpawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;

    void SpawnObject()
    {
        int randomNumber = Random.Range(0,objectToSpawn.Length);
        GameObject newObject = Instantiate(objectToSpawn[randomNumber], transform.position, objectToSpawn[randomNumber].transform.rotation);
        //newObject.transform.parent = transform;
    }

    //void SpawnObject2()
    //{
    //    GameObject newObject = Instantiate(objectToSpawn2, transform.position, objectToSpawn2.transform.rotation);
    //    //newObject.transform.parent = transform;
    //}


    void deleteObject()
    {
        GameObject destroy = GameObject.Find("Cube(Clone)");
        Destroy(destroy);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right")||Input.GetKeyDown("left"))
        {
            SpawnObject();
        }
        if (Input.GetKey(KeyCode.D))
       {
            //deleteObject();
            GameObject.Destroy(gameObject);
       }
    }
}
