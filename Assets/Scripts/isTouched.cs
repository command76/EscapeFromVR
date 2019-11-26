using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class isTouched : MonoBehaviour
{
 public int buttonNum;
 //public float buttonDelayTime;
 public TouchButton other; 
 public BookShelfControl ScriptA;
 public bool YAxis;
 public bool opensBookShelf;
 private bool hasntPlayedYet;
private float buttonDelayTime = 0.7f;
private bool buttonPressed = false;

    void start()
    {
    }
   void OnTriggerEnter(Collider otherobj)
    {
        if (otherobj.gameObject.CompareTag("Glasszone"))
        {
            Debug.Log("Hit from glasses");
        }else{
            if(buttonPressed == false){
                if(!YAxis)
                {
                    transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 0.009f);
                    Debug.Log("button" + buttonNum); 
                    other.SafeLogic(buttonNum, opensBookShelf);
                    buttonPressed = true;
                }else if(YAxis){
                    transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y - 0.009f, transform.localPosition.z);
                    Debug.Log("button" + buttonNum); 
                    other.SafeLogic(buttonNum, opensBookShelf); 
                    buttonPressed = true;
                }
                StartCoroutine(ButtonDelay()); 
            }
        }
        if(opensBookShelf == true && hasntPlayedYet == false){
            hasntPlayedYet = true;
            ScriptA.RetractBookShelf();
        }
    }
    IEnumerator ButtonDelay()
    {
        yield return new WaitForSeconds(buttonDelayTime);
            if(!YAxis)
            {
                transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 0.009f);
                Debug.Log("button" + buttonNum); 
            } else{
                transform.localPosition = new Vector3( transform.localPosition.x, transform.localPosition.y + 0.009f, transform.localPosition.z);
                Debug.Log("button" + buttonNum);  
            }
        buttonPressed = false;
    }
}