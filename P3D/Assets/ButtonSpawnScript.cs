using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pickUpGameObject;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    private void Awake()
    {
        pickUpGameObject = GameObject.FindGameObjectWithTag("pickup");
        _audioSource = GetComponent<AudioSource>();
    }

    public void SpawnPickUpObject()
    {
        _audioSource.PlayOneShot(_audioClip);
        Instantiate(pickUpGameObject);
    }
}
