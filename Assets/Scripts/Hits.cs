using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hits : MonoBehaviour
{
    float hits;
    // Start is called before the first frame update
    void Start()
    {
        hits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Border")
            Debug.Log("hit a border");
        if (collision.gameObject.tag == "Obstacle")
            Debug.Log("hit a obstacle");
            
    }
}
