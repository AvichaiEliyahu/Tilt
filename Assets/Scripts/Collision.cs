using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    AudioSource source;
    [SerializeField] AudioClip hitSound;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            source.PlayOneShot(hitSound);
    }
}
