using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endGame2 : MonoBehaviour

{
    // Start is called before the first frame update
    private float fallDelayTime =5f;
        void Start()
    {
        StartCoroutine(FallDelay());
    }

    // Update is called once per frame
    void Update()
    {

    } 

    IEnumerator FallDelay()
    {
        yield return new WaitForSeconds(fallDelayTime);
        SceneManager.LoadScene("gameplayscene"); 
        
    }
}
