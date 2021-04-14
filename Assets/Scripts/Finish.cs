using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] AudioClip success;
    bool isTransitioning=false;
    AudioSource source;
    TimeCounter counterScript;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        counterScript = FindObjectOfType<TimeCounter>();
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (!isTransitioning)
        {
            FinishSequence();
        }
    }

    void FinishSequence()
    {
        isTransitioning = true;
        Debug.Log("finish!");
        source.PlayOneShot(success);
        Invoke("ReloadLevel", 2f);
        counterScript.UpdateFinish(true,Time.timeSinceLevelLoad);
    }

    void ReloadLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
