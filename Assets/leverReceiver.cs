using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class leverReceiver : MonoBehaviour
{private static int[] correctCombo = {0, 1, 0, 1};
private int[] levers = {3, 3, 3, 3,};
public Animator anim;
public Animator anim2;
private bool playedOnce = false;
public float waitTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if ((levers[0] == correctCombo[0]) && (levers[1] == correctCombo[1])
                && (levers[2] == correctCombo[2]) && (levers[3] == correctCombo[3]))
                
            {
                if(playedOnce == false){
                playedOnce = true;
                Debug.Log("You did it!");
                anim.Play("FinalGameSequence");
                StartCoroutine(fadeInDelay());
                }
            }
    }

    public void leverTrue(int num)
    {
        levers[num] = 1;
        Debug.Log(levers[num]);
    }
    public void leverFalse(int num)
    {
        levers[num] = 0;
        Debug.Log(levers[num]);
    }
    IEnumerator fadeInDelay()
    {
        yield return new WaitForSeconds(waitTime);
        anim2.Play("headsphereFadein");
    }
}
