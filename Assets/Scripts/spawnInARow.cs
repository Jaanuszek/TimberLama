using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnInARow : MonoBehaviour
{
    public Vector3 firstPosition;
    public float gap = 2;
    public GameObject objectToCreate;
    // Start is called before the first frame update
    void Start()
    {
        Vector3  position = firstPosition;
        for (int i = 0; i<4; i++)
        {
            Instantiate(objectToCreate, position, Quaternion.identity);
            position.y += gap;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
