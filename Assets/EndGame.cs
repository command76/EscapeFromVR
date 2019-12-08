using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    private float fallDelayTime = 4f;
    public bool endGame = false;
    // Start is called before the first frame update
    void Start()
    {
                
    }
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
      /*   if (Input.GetButtonDown("VRTK_Axis9_LeftTrigger"))
        {
           // RetractBookShelf(); 
        StartCoroutine(FallDelay());     
        }   
        if (Input.GetButtonDown("VRTK_Axis10_RightTrigger"))        
        {
           // RetractBookShelf(); 
        StartCoroutine(FallDelay());     
        }  */
    }
public void restartGame()
    {
        if (endGame == true)
        {                    
         StartCoroutine(FallDelay()); 
        }             
    }
    IEnumerator FallDelay()
    {
        yield return new WaitForSeconds(fallDelayTime);
        SceneManager.LoadScene("gameplayscene"); 
        endGame = false;        
    }

}
