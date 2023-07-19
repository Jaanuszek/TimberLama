using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    public GameObject instantiatedObj;

    void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation) as GameObject;
        if (Input.GetKeyDown("left"))
        {
            Destroy(newObject);
        }
    }


    void deleteObject()
    {
        GameObject destroy = GameObject.Find("Cube(Clone)");
        Destroy(destroy);
    }

    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("SpawnObject", 0, 0.5f); //zrobic tak zeby zrespilo sie 5 i potem przestalo respic

        
    }

    // Update is called once per frame
    void Update()
    {
        // 1 sposob na przestanie respienia sie objektow w nieskonczonosc
        //if (Input.GetKey(KeyCode.Return)) 
        //{
        //    CancelInvoke();
        //}
        if (Input.GetKeyDown("right")||Input.GetKeyDown("left"))
        {
            SpawnObject();
        }
        if (Input.GetKey(KeyCode.D))
       {
            deleteObject();
       }
    }
}
