using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tilt : MonoBehaviour
{
    [SerializeField] float tiltSpeed = 0.1f;
    [SerializeField] float tiltLimit = 10f;

    float xTiltInput;
    float zTiltInput;
  

    // Update is called once per frame
    void Update()
    {
        ProccesTilt();
        if (Input.GetKeyDown(KeyCode.R))
            RestartLevel();
    }

    void RestartLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene(nextSceneIndex);

        
    }
    private void ProccesTilt()
    {
        xTiltInput = Input.GetAxis("Vertical");
        zTiltInput = -Input.GetAxis("Horizontal");

        float xOffset = xTiltInput * Time.deltaTime * tiltSpeed;
        float newXtilt = transform.localEulerAngles.x + xOffset;

        float zOffset = zTiltInput * Time.deltaTime * tiltSpeed;
        float newZtilt = transform.localEulerAngles.z + zOffset;

        transform.localEulerAngles = new Vector3(newXtilt, transform.localEulerAngles.y, newZtilt);
    }

}
