using UnityEngine;
using System.Collections;

public class BookShelfControl : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public GameObject audioSound;

    void Start()
    {
        anim = GetComponent<Animator>();       
    }
    void Update()
    {
        if (Input.GetButtonDown("VRTK_Axis9_LeftTrigger"))
        {
           // RetractBookShelf();      
        }   
        if (Input.GetKeyDown("i"))
        {
            //RetractBookShelf();   
        }    
    }
    public void RetractBookShelf()
        {
        anim.Play("BookShelfRetract"); 
        audioSound.SetActive(true);
        anim2.Play("DoorIdle");
        }  
}

 