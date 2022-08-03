using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pickUpGameObject;

    private void Awake()
    {
        pickUpGameObject = GameObject.FindGameObjectWithTag("pickup");
    }

    public void SpawnPickUpObject()
    {
        Instantiate(pickUpGameObject);
    }
}
