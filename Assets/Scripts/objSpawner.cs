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
        GameObject newObject = Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
    }


    void deleteObject()
    {
        //instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
        //Destroy(instantiatedObj);
    }

    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("SpawnObject", 0, 0.5f); //zrobic tak zeby zrespilo sie 5 i potem przestalo respic
        
    }

    // Update is called once per frame
    void Update()
    {
        //drugi sposób
         //if (currentTimeToSpawn > 0)
         //{
         //
         //   currentTimeToSpawn -= Time.deltaTime;
         //}
         //else
         //{
         //   CancelInvoke();
         //   currentTimeToSpawn = timeToSpawn;
         //}

        // 1 sposob na przestanie respienia sie objektow w nieskonczonosc
        //if (Input.GetKey(KeyCode.Return)) 
        //{
        //    CancelInvoke();
        //}
        
        //TODO!!
        //ALBO MOZNA TO TAK ZROBIC ZE JAK SIE ZRESPI TYCH BLOKOW DO KONKRETNEJ WYSOKOSCI TO WYKRYWA TO KOD I PRZESTAJE RESPIC

      if (Input.GetKeyDown("right"))
        {
            SpawnObject();
        }   
      else if (Input.GetKeyDown("left"))
        {
            SpawnObject();
        }
       if (Input.GetKey(KeyCode.D))
       {
            // if (gameObject.name == "Cube(clone)")
            // {
            //     Destroy(gameObject);
            // }
            //Destroy(instantiatedObj);
            deleteObject();
       }
    }
}
