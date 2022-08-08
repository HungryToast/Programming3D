using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUpController : MonoBehaviour
{
   [SerializeField] Rigidbody rb;
   [SerializeField] BoxCollider col;

   [SerializeField] private AudioSource _audioSource;
   [SerializeField] private AudioClip pickUpClip;
   [SerializeField] private AudioClip putDownClip;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
      col = GetComponent<BoxCollider>();
      _audioSource = GetComponent<AudioSource>();
   }

   private void Start()
   {
      rb.isKinematic = false;
      col.isTrigger = false;
   }

   public void Pickup()
   {
      rb.isKinematic = true;
      col.isTrigger = true;
      _audioSource.PlayOneShot(pickUpClip);
   }

   public void PutDown()
   {
      rb.isKinematic = false;
      col.isTrigger = false;
      _audioSource.PlayOneShot(putDownClip);
   }


}
