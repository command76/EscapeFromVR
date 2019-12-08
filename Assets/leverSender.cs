using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverSender : MonoBehaviour
{

public leverReceiver other;
public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leverUP()
    {
        Debug.Log("Lever Up");
        other.leverTrue(num);
    }
    public void leverDOWN()
    {
        Debug.Log("Lever Down");
        other.leverFalse(num);
    }
}
