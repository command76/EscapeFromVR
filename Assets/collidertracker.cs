using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidertracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhatCollided(GameObject go) {
        Debug.Log(go.gameObject.name);
    }

     //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log(collision.gameObject.name);

    }
}
