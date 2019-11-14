using UnityEngine;
using System.Collections;

public class BookShelfControl : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();       
    }
    void Update()
    {
        if (Input.GetButtonDown("VRTK_Axis9_LeftTrigger"))
        {
            RetractBookShelf();      
        }   
        if (Input.GetKeyDown("i"))
        {
            RetractBookShelf();   
        }    
    }
    public void RetractBookShelf()
        {
        anim.Play("BookShelfRetract"); 
        }  
}

 