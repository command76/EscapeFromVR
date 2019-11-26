using UnityEngine;
using System.Collections;

public class HeadSphereControl : MonoBehaviour
{
    public Animator anim;
    public static bool areGlassesEquiped;
    public GameObject turnoff1;
    public GameObject turnoff2;
    public GameObject turnoff3;
    public GameObject turnon1;
    public GameObject turnon2;
    public GameObject turnon3;
    public Renderer catPoster;
    public Material CatPosterOrig;
    public Material CatPosterNew;
    private bool ishighlighted; 
    public float highlightDelaytime = 0.5f;
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
        ishighlighted = true;
        highlightDelaytime = 0.2f;
        StartCoroutine(HighlightDelay());       
    }
    void TakeOffGlasses()
    {
        Debug.Log("Took off glases");
        makeGlassesFalse();
        ishighlighted = false;
        highlightDelaytime = 0.7f;
        StartCoroutine(HighlightDelay()); 
    }
    void makeGlassesFalse()
    {
        areGlassesEquiped = false;
    }
    void makeGlassesTrue()
    {
        areGlassesEquiped = true;
    }
    IEnumerator HighlightDelay()
    {
        yield return new WaitForSeconds(highlightDelaytime);
        if(ishighlighted == true){
            turnoff1.SetActive(false);
            turnoff2.SetActive(false);
            turnoff3.SetActive(false);
            turnon1.SetActive(true);
            turnon2.SetActive(true); 
            turnon3.SetActive(true);
            catPoster.material = CatPosterNew;
        }else{
            turnoff1.SetActive(true);
            turnoff2.SetActive(true);
            turnoff3.SetActive(true);
            turnon1.SetActive(false);
            turnon2.SetActive(false); 
            turnon3.SetActive(false);  
            catPoster.material = CatPosterOrig;          
        }        
    }
}
