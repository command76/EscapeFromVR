using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTwoGameManager : MonoBehaviour
{
   

   public GameObject lever1;
   public GameObject lever2;
   public GameObject lever3;
   public GameObject lever4;
   public bool lever1True;
   public bool lever2True;
   public bool lever3True;
   public bool lever4True;
   public LeverTargetReached leverTargetReached1;
   public LeverTargetReached leverTargetReached2;
   public LeverTargetReached leverTargetReached3;
   public LeverTargetReached leverTargetReached4;

    void Awake()
    {
        FindLevers();
        FindLeverScripts();
    }
    void Update()
    {
        if(leverTargetReached1.targetRotationValueReached == false 
        && leverTargetReached2.targetRotationValueReached == false
        && leverTargetReached3.targetRotationValueReached == false
        && leverTargetReached4.targetRotationValueReached == false)
        {
            Debug.Log("HI");
        }
        
    }

    void FindLevers()
    {
        lever1 = GameObject.Find("Lever1");
        lever2 = GameObject.Find("Lever2");
        lever3 = GameObject.Find("Lever3");
        lever4 = GameObject.Find("Lever4");
    }
    void FindLeverScripts()
    {
       leverTargetReached1 =  lever1.GetComponent<LeverTargetReached>();
       leverTargetReached2 = lever2.GetComponent<LeverTargetReached>();
        leverTargetReached3 = lever3.GetComponent<LeverTargetReached>();
       leverTargetReached4 =  lever4.GetComponent<LeverTargetReached>();
    }

}
