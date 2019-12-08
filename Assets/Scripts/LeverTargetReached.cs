using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTargetReached : MonoBehaviour
{
    public GameObject rotationValue;
    public int targetRotationValue;
    public bool targetRotationValueReached = false;
    
    void Update()
    {
        if(rotationValue.transform.localRotation.z == targetRotationValue)
        {
            TargetRotationValueReached();
        
        }
    }
    public void TargetRotationValueReached()
    {
        targetRotationValueReached = true;
        Debug.Log("yo");
    }
    
}
