using UnityEngine;
using System.Collections;

public class HeadSphereControl : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();        
    }
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            InflateSphere();      
        }      
        if (Input.GetKeyDown("p"))
        {
            CollapseSphere();   
        }     
    }
    public void CollapseSphere()
        {
        anim.Play("HeadSphereCollapseInward"); 
        }
    public void InflateSphere()
        {
        anim.Play("HeadSphereSpreadOut"); 
        }
}
