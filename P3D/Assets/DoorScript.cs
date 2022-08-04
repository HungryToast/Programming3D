using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool doorState;
    
    public void OpenDoor()
    {
        doorState = true;
        print("Open");
        transform.rotation = new Quaternion(0,  90, 0, 0);
    }

    public void CloseDoor()
    {
         doorState = false;
         print("Close"); 
         transform.rotation = new Quaternion(0, 0, 0, 0);
       
    }
}
