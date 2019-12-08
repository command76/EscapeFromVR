using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedPoster : MonoBehaviour
{

    private Animator anim;
    public GameObject paperSheet;
    public GameObject spawnPoint;
    public bool playedOnce;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touched()
    {
        anim.Play("PosterTouched");
        Debug.Log("Poster Touched");
    }
  /* public void OnTriggerEnter(Collision other)
   {
       if(other.gameObject.tag != "Glasszone")
       {
           anim.Play("PosterTouched");
       }
   }*/

   void OnTriggerEnter(Collider otherobj)
    {
        if (otherobj.gameObject.CompareTag("Glasszone"))
        {
            Debug.Log("Hit from glasses");
        }else
        {
            if(playedOnce == false)
            {
            anim.Play("PosterTouched");  
            Instantiate (paperSheet, spawnPoint.transform.position, this.transform.rotation); 
            playedOnce = true; 
            }        
        }
    }
}
