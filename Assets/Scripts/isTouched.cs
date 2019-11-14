using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class isTouched : MonoBehaviour
{
 public int buttonNum;
 public TouchButton other; 

    void start()
    {
 
    }
    public void OnTriggerEnter()
    {
        transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 0.009f);
        Debug.Log("button" + buttonNum); 
        other.SafeLogic(buttonNum); 
    }
    public void OnTriggerExit()
    {
        transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 0.009f);
        Debug.Log("button" + buttonNum);  
    }
}