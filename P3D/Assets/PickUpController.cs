using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUpController : MonoBehaviour
{
   [SerializeField] Rigidbody rb;
   [SerializeField] CapsuleCollider col;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
      col = GetComponent<CapsuleCollider>();
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
   }

   public void PutDown()
   {
      rb.isKinematic = false;
      col.isTrigger = false;
   }


}
