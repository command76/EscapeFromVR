using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    private float fallDelayTime = 8f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FallDelay());        
    }
    void Awake()
    {

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
