using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    [SerializeField] float tiltSpeed = 0.1f;
    [SerializeField] float tiltlimit;

    float xTilt;
    float zTilt;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xTilt = Input.GetAxis("Vertical");
        zTilt = Input.GetAxis("Horizontal");

        transform.Rotate(new Vector3(xTilt,0,-zTilt)*tiltSpeed);
    }
}
