using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnInARow : MonoBehaviour
{
    public Vector3 firstPosition;
    public float gap = 2;
    public GameObject[] objectToCreate;
    public int numberOfObjects;
    // Start is called before the first frame update
    void Start()
    {
        Vector3  position = firstPosition;
        for (int i = 0; i<numberOfObjects; i++)
        {
            int randomNumber = Random.Range(0, objectToCreate.Length);
            Instantiate(objectToCreate[randomNumber], position, Quaternion.identity);
            position.y += gap;
        }
    }
}
