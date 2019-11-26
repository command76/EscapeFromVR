using UnityEngine;
using System.Collections;

public class SafeControl : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();       
    }
    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            //OpenSafe();      
        }   
    }
    public void OpenSafe()
        {
        //anim.Play("SafeDoorOpen"); 
        }  
}