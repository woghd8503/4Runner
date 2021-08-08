using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTriggerCheck : MonoBehaviour
{
    private AudioSource shoutingSound;
    void Start()
    {
        shoutingSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shoutingSound.Play();
        }
        //Destroy(this.gameObject, shoutingSound.clip.length);
    }
}
