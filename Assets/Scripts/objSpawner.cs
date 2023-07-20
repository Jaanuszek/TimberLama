using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class objSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public GameObject instantiatedObj;

    void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        newObject.transform.parent = transform;
    }


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
