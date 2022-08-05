using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool doorState;
    public AudioSource audioSource;
    public AudioClip doorSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OpenDoor()
    {
        audioSource.PlayOneShot(doorSound);
        doorState = true;
        print("Open");
        transform.rotation = new Quaternion(0,  90, 0, 0);
    }

    public void CloseDoor()
    {
        audioSource.PlayOneShot(doorSound);
         doorState = false;
         print("Close"); 
         transform.rotation = new Quaternion(0, 0, 0, 0);
       
    }
}
