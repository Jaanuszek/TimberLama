using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 pozycja;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            transform.position = new Vector3(-2f,0.5f,0);
        }

        if (Input.GetKeyDown("right"))
        {
            transform.position = new Vector3(2f, 0.5f, 0);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Destroy(other.gameObject);
        }
    }
    
}
