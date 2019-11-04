using UnityEngine;
using System.Collections;

public class HeadSphereControl : MonoBehaviour
{
    public Animator anim;
    public static bool areGlassesEquiped;
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
        TakeOffGlasses();
        }
    public void InflateSphere()
        {
        anim.Play("HeadSphereSpreadOut"); 
        EquipGlasses();
        }
    void EquipGlasses()
    {
        Debug.Log("Equipped glases");
        makeGlassesTrue();
    }
    void TakeOffGlasses()
    {
        Debug.Log("Took off glases");
        makeGlassesFalse();
    }
    void makeGlassesFalse()
    {
        areGlassesEquiped = false;
    }
    void makeGlassesTrue()
    {
        areGlassesEquiped = true;
    }
}
