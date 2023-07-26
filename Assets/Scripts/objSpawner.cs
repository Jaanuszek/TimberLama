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
    }
}
